using BlueMystic;
using System;
using System.Runtime.InteropServices;
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
            DarkModeCS darkMode = new DarkModeCS(this);

            // Set the window corner preference for the context menu strip
            var contextMenuStrip = new ContextMenuStrip();
            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = (int)DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(contextMenuStrip.Handle, (int)attribute, ref preference, sizeof(int));
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Read the settings from the registry
            var settings = PingTester.Program.ReadSettings();
            this.BackColor = ColorTranslator.FromHtml("#2b2b2b");
            // Populate the textboxes with the settings values
            pingCountTextBox.Text = settings.PingCount.ToString();
            secondsBetweenPingsTextBox.Text = settings.SecondsBetweenPings.ToString();
            maxResponseTimeTextBox.Text = settings.MaxResponseTime.ToString();
            serverToPingTextBox.Text = settings.ServerToPing;
            perfectThresholdTextBox.Text = settings.PerfectThreshold.ToString();
            goodThresholdTextBox.Text = settings.GoodThreshold.ToString();
            mediumThresholdTextBox.Text = settings.MediumThreshold.ToString();
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
    }
}