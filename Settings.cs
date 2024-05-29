using BlueMystic;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static BlueMystic.DarkModeCS;


namespace SettingsWindow
{

    public partial class Settings : Form
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);
        public Settings()
        {
            InitializeComponent();
            
            StartPosition = FormStartPosition.CenterScreen;
            Icon = PingTester.Properties.Resources.Perfect;
            this.MinimizeBox = true;  // Habilita el botón de minimizar
            this.MaximizeBox = false; // Deshabilita el botón de maximizar

            // Set the window corner preference for the context menu strip
            var contextMenuStrip = new ContextMenuStrip();
            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = (int)DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(contextMenuStrip.Handle, (int)attribute, ref preference, sizeof(int));
            Console.SetOut(new ControlWriter(consoleOutput));
            SetTitleBarColor();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Read the settings from the registry
            var settings = PingTester.Program.ReadSettings();
            this.BackColor = ColorTranslator.FromHtml("#242424");


            // Populate the textboxes with the settings values
            pingCountTextBox.Text = settings.PingCount.ToString();
            secondsBetweenPingsTextBox.Text = settings.SecondsBetweenPings.ToString();
            maxResponseTimeTextBox.Text = settings.MaxResponseTime.ToString();
            serverToPingTextBox.Text = settings.ServerToPing;
            perfectThresholdTextBox.Text = settings.PerfectThreshold.ToString();
            goodThresholdTextBox.Text = settings.GoodThreshold.ToString();
            mediumThresholdTextBox.Text = settings.MediumThreshold.ToString();
        }
        private void SetTitleBarColor()
        {
            // Define el atributo DWMWA_CAPTION_COLOR
            const int DWMWA_CAPTION_COLOR = 35;
            // Define el color que deseas para la barra de título (Negro en este caso)
            int color = 0x202020; // Color negro en formato BGR
            // Configura el atributo de la ventana
            DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref color, sizeof(int));
        }
        private void TogglePanelsButton_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = !settingsPanel.Visible;
            additionalPanel.Visible = !additionalPanel.Visible;
            
            if (this.togglePanelsButton.Text.Equals("Show console"))
            {
                this.togglePanelsButton.Text = "Show parameters";
                
            }
            else if (this.togglePanelsButton.Text.Equals("Show parameters"))
            {
                this.togglePanelsButton.Text = "Show console";
                return;
            }

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Create a new Settings object with the updated values
            var settings = new PingTester.Settings
            {
                PingCount = int.Parse(pingCountTextBox.Text),
                SecondsBetweenPings = float.Parse(secondsBetweenPingsTextBox.Text),
                MaxResponseTime = int.Parse(maxResponseTimeTextBox.Text),
                ServerToPing = serverToPingTextBox.Text,
                PerfectThreshold = int.Parse(perfectThresholdTextBox.Text),
                GoodThreshold = int.Parse(goodThresholdTextBox.Text),
                MediumThreshold = int.Parse(mediumThresholdTextBox.Text)
            };

            // Save the updated settings to the registry
            PingTester.Program.SaveSettings(settings);
            PingTester.Program.settingsChanged = true;
            // Close the Settings form
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close the Settings form without saving
            Close();
        }

        private void configurationLabel_Click(object sender, EventArgs e)
        {

        }

        private void secondsBetweenPingsLabel_Click(object sender, EventArgs e)
        {

        }

        private void pingCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void serverToPingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxResponseTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pingCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void additionalPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class ControlWriter : TextWriter
    {
        private RichTextBox textbox;

        public ControlWriter(RichTextBox textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            textbox.Invoke(new MethodInvoker(() =>
            {
                textbox.AppendText(value.ToString());
                ScrollToBottom(textbox);
            }));
        }

        public override void WriteLine(string value)
        {
            if (!textbox.IsDisposed && textbox.IsHandleCreated)
            {
                textbox.Invoke(new MethodInvoker(() =>
                {
                    textbox.AppendText(value + "\n");
                    ScrollToBottom(textbox);
                }));
            }
        }

        private void ScrollToBottom(RichTextBox textbox)
        {
            // Desplazar automáticamente hacia abajo
            textbox.SelectionStart = textbox.Text.Length;
            textbox.ScrollToCaret();
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }

}