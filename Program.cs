using System;
using Microsoft.Win32;
using System.Text.Json;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace PingTester
{
    class Program
    {
        static bool stopPingTest = false;
        static NotifyIcon trayIcon;
        public static bool settingsChanged = false;

        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var settings = ReadSettings();
            SetInitialTooltip(settings);

            trayIcon.ContextMenuStrip = new ContextMenuStrip();
            trayIcon.ContextMenuStrip.Renderer = new DarkModeRenderer();
            trayIcon.ContextMenuStrip.ShowImageMargin = false;
            trayIcon.ContextMenuStrip.Items.Add("Like the app? Buy me a coffee!", null, onCoffeeClick);
            trayIcon.ContextMenuStrip.Items.Add("Settings", null, onSettingsClick);

            trayIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            trayIcon.ContextMenuStrip.Items.Add("Exit", null, OnExitClick);

            var pingTestThread = new Thread(PingTest);
            pingTestThread.IsBackground = true;
            pingTestThread.Start();

            Application.Run();
        }

        static void SetInitialTooltip(Settings settings)
        {
            
            int pingCount = settings.PingCount;
            double secondsBetweenPings = settings.SecondsBetweenPings;
            int maxResponseTime = settings.MaxResponseTime;
            string serverToPing = settings.ServerToPing;

            double estimatedTestTime = pingCount * secondsBetweenPings;

            string tooltip = string.Format(
                "[Performing test]\n" +
                "To: {0}\n" +
                "Pings: {1}\n" +
                "Interval: {2:F1}s\n" +
                "Timeout: {3}ms\n" +
                "Test duration: {4:F1}s",
                serverToPing,
                pingCount,
                secondsBetweenPings,
                maxResponseTime,
                estimatedTestTime
            );

            trayIcon = new NotifyIcon
            {
                Icon = Properties.Resources.Waiting,
                Text = tooltip,
                Visible = true
            };
        }

        static void PingTest()
        {
            bool stopPingTest = false;
            settingsChanged = true;
            int pingCount = 0;
            float secondsBetweenPings = 0;
            int timeUntilLost = 0;
            string serverToPing = "";
            int perfectThreshold = 0;
            int goodThreshold = 0;
            int mediumThreshold = 0;

            Regex responseTimePattern = new Regex(@"(\d+(?:\.\d+)?)ms");

            while (!stopPingTest)
            {
                if (settingsChanged)
                {
                    var settings = ReadSettings();
                    pingCount = settings.PingCount;
                    secondsBetweenPings = settings.SecondsBetweenPings;
                    timeUntilLost = settings.MaxResponseTime;
                    serverToPing = settings.ServerToPing;
                    perfectThreshold = settings.PerfectThreshold;
                    goodThreshold = settings.GoodThreshold;
                    mediumThreshold = settings.MediumThreshold;

                    settingsChanged = false;
                }

                int successfulPings = 0;
                int packetLoss = 0;
                var responseTimes = new List<float>();

                for (int i = 0; i < pingCount && !stopPingTest; i++)
                {
                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "ping",
                            Arguments = $"-n 1 -w {timeUntilLost} {serverToPing}",
                            RedirectStandardOutput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        }
                    };

                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    string[] lines = output.Split('\n'); // Dividir la salida en líneas
                    double totalResponseTime = 0;
                    int responseCount = 0;

                    foreach (string line in lines)
                    {
                        if (line.Contains("time="))
                        {
                            int timeIndex = line.IndexOf("time=") + 5;
                            int msIndex = line.IndexOf("ms");
                            string responseTimeString = line.Substring(timeIndex, msIndex - timeIndex).Trim();
                            double responseTime = double.Parse(responseTimeString); // Convierte el tiempo de respuesta a double
                            totalResponseTime += responseTime;
                            responseCount++;

                            double averageResponseTime = totalResponseTime / responseCount; // Calcula el promedio

                            Console.WriteLine($"To: {serverToPing} Response: {responseTime}ms Average: {averageResponseTime}ms");
                        }
                    }


                    var match = responseTimePattern.Match(output);
                    if (match.Success)
                    {
                        successfulPings++;
                        float responseTime = float.Parse(match.Groups[1].Value);
                        responseTimes.Add(responseTime);
                    }
                    else
                    {
                        packetLoss++;
                    }
                    Thread.Sleep((int)(secondsBetweenPings * 1000));
                }

                float packetLossPercentage = (float)packetLoss / pingCount * 100;

                if (packetLossPercentage < perfectThreshold)
                {
                    Console.WriteLine("Perfect connectivity");
                    trayIcon.Icon = Properties.Resources.Perfect;
                }
                else if (packetLossPercentage < goodThreshold)
                {
                    Console.WriteLine("Good connectivity");
                    trayIcon.Icon = Properties.Resources.Good;
                }
                else if (packetLossPercentage < mediumThreshold)
                {
                    Console.WriteLine("Medium connectivity");
                    trayIcon.Icon = Properties.Resources.Medium;
                }
                else
                {
                    trayIcon.Icon = Properties.Resources.Bad;
                }

                UpdateStatistics(successfulPings, packetLoss, responseTimes, serverToPing);
            }
        }

        public static Settings ReadSettings()
        {
            string registryPath = @"Software\PingTester";
            var defaultSettings = new Settings
            {
                PingCount = 10,
                SecondsBetweenPings = 1,
                MaxResponseTime = 150,
                ServerToPing = "google.com",
                PerfectThreshold = 9,
                GoodThreshold = 18,
                MediumThreshold = 28
            };

            try
            {
                using (var registryKey = Registry.CurrentUser.OpenSubKey(registryPath))
                {
                    if (registryKey != null)
                    {
                        string settingsStr = registryKey.GetValue("Parameters")?.ToString();
                        if (!string.IsNullOrEmpty(settingsStr))
                        {
                            return JsonSerializer.Deserialize<Settings>(settingsStr);
                        }
                    }
                }
                SaveSettings(defaultSettings);
            }
            catch (Exception)
            {
                Console.WriteLine("Registry entry not found or invalid. Using default settings.");
            }

            return defaultSettings;
        }

        public static void SaveSettings(Settings settings)
        {
            string registryPath = @"Software\PingTester";
            string settingsStr = JsonSerializer.Serialize(settings);

            using (var registryKey = Registry.CurrentUser.CreateSubKey(registryPath))
            {
                registryKey.SetValue("Parameters", settingsStr);
            }
        }

        static void onSettingsClick(object sender, EventArgs e)
        {
            // Create an instance of the Settings form
            SettingsWindow.Settings settingsForm = new SettingsWindow.Settings();

            // Show the Settings form as a dialog
            settingsForm.ShowDialog();
        }

        static void onCoffeeClick(object sender, EventArgs e)
        {
            string url = "https://ko-fi.com/gdsdev";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        static void OnExitClick(object sender, EventArgs e)
        {
            stopPingTest = true;
            Application.Exit();
        }

        static void UpdateStatistics(int successfulPings, int packetLoss, List<float> responseTimes, string serverToPing)
        {
            float averageResponseTime = 0;
            float minResponseTime = 0;
            float maxResponseTime = 0;

            if (successfulPings > 0)
            {
                averageResponseTime = responseTimes.Sum() / successfulPings;
                minResponseTime = responseTimes.Min();
                maxResponseTime = responseTimes.Max();
            }

            float packetLossPercentage = (float)packetLoss / (successfulPings + packetLoss) * 100;

            string tooltip = string.Format(
                "[Packet statistics]\n" +
                "Sent: {0}\n" +
                "Lost: {1} ({2:F2}%)\n" +
                "To: {3}\n" +
                "Avg. RTT: {4:F2}ms\n" +
                "Min. RTT: {5:F2}ms\n" +
                "Max. RTT: {6:F2}ms",
                successfulPings + packetLoss,
                packetLoss,
                packetLossPercentage,
                serverToPing,
                averageResponseTime,
                minResponseTime,
                maxResponseTime
            );

            trayIcon.Text = tooltip;
        }
    }

    class Settings
    {
        public int PingCount { get; set; }
        public float SecondsBetweenPings { get; set; }
        public int MaxResponseTime { get; set; }
        public string ServerToPing { get; set; }
        public int PerfectThreshold { get; set; }
        public int GoodThreshold { get; set; }
        public int MediumThreshold { get; set; }
    }

    class DarkModeRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#4b4b4b")), e.Item.ContentRectangle);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#2b2b2b")), e.Item.ContentRectangle);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = Color.White;
            base.OnRenderItemText(e);
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Color.White;
            base.OnRenderArrow(e);
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            // No dibujar el borde predeterminado
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#2b2b2b")), e.AffectedBounds);
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#2b2b2b")), e.AffectedBounds);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            int separatorThickness = 1; // Thickness of the separator line in pixels
            int separatorMargin = 6; // Margin on the left and right of the separator line

            int x1 = e.Item.ContentRectangle.Left + separatorMargin;
            int x2 = e.Item.ContentRectangle.Right - separatorMargin;
            int y = e.Item.ContentRectangle.Top + (e.Item.ContentRectangle.Height - separatorThickness) / 2;

            e.Graphics.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#6b6b6b")), x1, y, x2 - x1, separatorThickness);
        }
    }
}