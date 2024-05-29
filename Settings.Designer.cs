
namespace SettingsWindow
{
    partial class Settings
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            configurationLabel = new Label();
            pingCountLabel = new Label();
            pingCountTextBox = new TextBox();
            secondsBetweenPingsLabel = new Label();
            secondsBetweenPingsTextBox = new TextBox();
            maxResponseTimeLabel = new Label();
            maxResponseTimeTextBox = new TextBox();
            serverToPingLabel = new Label();
            perfectThresholdLabel = new Label();
            perfectThresholdTextBox = new TextBox();
            goodThresholdLabel = new Label();
            goodThresholdTextBox = new TextBox();
            mediumThresholdLabel = new Label();
            mediumThresholdTextBox = new TextBox();
            applyChangesButton = new Button();
            serverToPingTextBox = new TextBox();
            settingsPanel = new Panel();
            label1 = new Label();
            additionalPanel = new Panel();
            consoleOutput = new RichTextBox();
            togglePanelsButton = new Button();
            settingsPanel.SuspendLayout();
            additionalPanel.SuspendLayout();
            SuspendLayout();
            // 
            // configurationLabel
            // 
            configurationLabel.AutoSize = true;
            configurationLabel.Font = new Font("Microsoft JhengHei", 13.25F, FontStyle.Bold);
            configurationLabel.ForeColor = SystemColors.Control;
            configurationLabel.Location = new Point(124, 13);
            configurationLabel.Name = "configurationLabel";
            configurationLabel.Size = new Size(81, 23);
            configurationLabel.TabIndex = 0;
            configurationLabel.Text = "Console";
            configurationLabel.Click += configurationLabel_Click;
            // 
            // pingCountLabel
            // 
            pingCountLabel.AutoSize = true;
            pingCountLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            pingCountLabel.ForeColor = SystemColors.Control;
            pingCountLabel.Location = new Point(12, 47);
            pingCountLabel.Name = "pingCountLabel";
            pingCountLabel.Size = new Size(76, 17);
            pingCountLabel.TabIndex = 1;
            pingCountLabel.Text = "Ping count:";
            pingCountLabel.Click += pingCountLabel_Click;
            // 
            // pingCountTextBox
            // 
            pingCountTextBox.BackColor = Color.FromArgb(52, 54, 56);
            pingCountTextBox.BorderStyle = BorderStyle.FixedSingle;
            pingCountTextBox.ForeColor = SystemColors.InactiveCaption;
            pingCountTextBox.Location = new Point(181, 44);
            pingCountTextBox.Name = "pingCountTextBox";
            pingCountTextBox.Size = new Size(129, 23);
            pingCountTextBox.TabIndex = 2;
            pingCountTextBox.TextChanged += pingCountTextBox_TextChanged;
            // 
            // secondsBetweenPingsLabel
            // 
            secondsBetweenPingsLabel.AutoSize = true;
            secondsBetweenPingsLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            secondsBetweenPingsLabel.ForeColor = SystemColors.Control;
            secondsBetweenPingsLabel.Location = new Point(12, 79);
            secondsBetweenPingsLabel.Name = "secondsBetweenPingsLabel";
            secondsBetweenPingsLabel.Size = new Size(130, 17);
            secondsBetweenPingsLabel.TabIndex = 3;
            secondsBetweenPingsLabel.Text = "Seconds in between:";
            secondsBetweenPingsLabel.Click += secondsBetweenPingsLabel_Click;
            // 
            // secondsBetweenPingsTextBox
            // 
            secondsBetweenPingsTextBox.BackColor = Color.FromArgb(52, 54, 56);
            secondsBetweenPingsTextBox.BorderStyle = BorderStyle.FixedSingle;
            secondsBetweenPingsTextBox.ForeColor = SystemColors.InactiveCaption;
            secondsBetweenPingsTextBox.Location = new Point(181, 76);
            secondsBetweenPingsTextBox.Name = "secondsBetweenPingsTextBox";
            secondsBetweenPingsTextBox.Size = new Size(129, 23);
            secondsBetweenPingsTextBox.TabIndex = 4;
            // 
            // maxResponseTimeLabel
            // 
            maxResponseTimeLabel.AutoSize = true;
            maxResponseTimeLabel.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxResponseTimeLabel.ForeColor = SystemColors.Control;
            maxResponseTimeLabel.Location = new Point(12, 113);
            maxResponseTimeLabel.Name = "maxResponseTimeLabel";
            maxResponseTimeLabel.Size = new Size(125, 17);
            maxResponseTimeLabel.TabIndex = 5;
            maxResponseTimeLabel.Text = "Max response time:";
            // 
            // maxResponseTimeTextBox
            // 
            maxResponseTimeTextBox.BackColor = Color.FromArgb(52, 54, 56);
            maxResponseTimeTextBox.BorderStyle = BorderStyle.FixedSingle;
            maxResponseTimeTextBox.ForeColor = SystemColors.InactiveCaption;
            maxResponseTimeTextBox.Location = new Point(181, 110);
            maxResponseTimeTextBox.Name = "maxResponseTimeTextBox";
            maxResponseTimeTextBox.Size = new Size(129, 23);
            maxResponseTimeTextBox.TabIndex = 6;
            // 
            // serverToPingLabel
            // 
            serverToPingLabel.AutoSize = true;
            serverToPingLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            serverToPingLabel.ForeColor = SystemColors.Control;
            serverToPingLabel.Location = new Point(12, 147);
            serverToPingLabel.Name = "serverToPingLabel";
            serverToPingLabel.Size = new Size(95, 17);
            serverToPingLabel.TabIndex = 7;
            serverToPingLabel.Text = "Server to ping:";
            // 
            // perfectThresholdLabel
            // 
            perfectThresholdLabel.AutoSize = true;
            perfectThresholdLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            perfectThresholdLabel.ForeColor = SystemColors.Control;
            perfectThresholdLabel.Location = new Point(12, 181);
            perfectThresholdLabel.Name = "perfectThresholdLabel";
            perfectThresholdLabel.Size = new Size(114, 17);
            perfectThresholdLabel.TabIndex = 9;
            perfectThresholdLabel.Text = "Perfect threshold:";
            // 
            // perfectThresholdTextBox
            // 
            perfectThresholdTextBox.BackColor = Color.FromArgb(52, 54, 56);
            perfectThresholdTextBox.BorderStyle = BorderStyle.FixedSingle;
            perfectThresholdTextBox.ForeColor = SystemColors.InactiveCaption;
            perfectThresholdTextBox.Location = new Point(181, 178);
            perfectThresholdTextBox.Name = "perfectThresholdTextBox";
            perfectThresholdTextBox.Size = new Size(129, 23);
            perfectThresholdTextBox.TabIndex = 10;
            // 
            // goodThresholdLabel
            // 
            goodThresholdLabel.AutoSize = true;
            goodThresholdLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            goodThresholdLabel.ForeColor = SystemColors.Control;
            goodThresholdLabel.Location = new Point(12, 215);
            goodThresholdLabel.Name = "goodThresholdLabel";
            goodThresholdLabel.Size = new Size(106, 17);
            goodThresholdLabel.TabIndex = 11;
            goodThresholdLabel.Text = "Good threshold:";
            // 
            // goodThresholdTextBox
            // 
            goodThresholdTextBox.BackColor = Color.FromArgb(52, 54, 56);
            goodThresholdTextBox.BorderStyle = BorderStyle.FixedSingle;
            goodThresholdTextBox.ForeColor = SystemColors.InactiveCaption;
            goodThresholdTextBox.Location = new Point(181, 212);
            goodThresholdTextBox.Name = "goodThresholdTextBox";
            goodThresholdTextBox.Size = new Size(129, 23);
            goodThresholdTextBox.TabIndex = 12;
            // 
            // mediumThresholdLabel
            // 
            mediumThresholdLabel.AutoSize = true;
            mediumThresholdLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            mediumThresholdLabel.ForeColor = SystemColors.Control;
            mediumThresholdLabel.Location = new Point(12, 249);
            mediumThresholdLabel.Name = "mediumThresholdLabel";
            mediumThresholdLabel.Size = new Size(123, 17);
            mediumThresholdLabel.TabIndex = 13;
            mediumThresholdLabel.Text = "Medium threshold:";
            // 
            // mediumThresholdTextBox
            // 
            mediumThresholdTextBox.BackColor = Color.FromArgb(52, 54, 56);
            mediumThresholdTextBox.BorderStyle = BorderStyle.FixedSingle;
            mediumThresholdTextBox.ForeColor = SystemColors.InactiveCaption;
            mediumThresholdTextBox.Location = new Point(181, 246);
            mediumThresholdTextBox.Name = "mediumThresholdTextBox";
            mediumThresholdTextBox.Size = new Size(129, 23);
            mediumThresholdTextBox.TabIndex = 14;
            // 
            // applyChangesButton
            // 
            applyChangesButton.BackColor = Color.FromArgb(31, 106, 165);
            applyChangesButton.FlatStyle = FlatStyle.Popup;
            applyChangesButton.Font = new Font("Microsoft JhengHei UI", 9F);
            applyChangesButton.ForeColor = SystemColors.Control;
            applyChangesButton.Location = new Point(101, 279);
            applyChangesButton.Name = "applyChangesButton";
            applyChangesButton.Size = new Size(131, 26);
            applyChangesButton.TabIndex = 15;
            applyChangesButton.Text = "Apply changes";
            applyChangesButton.UseVisualStyleBackColor = false;
            applyChangesButton.Click += SaveButton_Click;
            // 
            // serverToPingTextBox
            // 
            serverToPingTextBox.BackColor = Color.FromArgb(52, 54, 56);
            serverToPingTextBox.BorderStyle = BorderStyle.FixedSingle;
            serverToPingTextBox.ForeColor = SystemColors.InactiveCaption;
            serverToPingTextBox.Location = new Point(181, 144);
            serverToPingTextBox.Name = "serverToPingTextBox";
            serverToPingTextBox.Size = new Size(129, 23);
            serverToPingTextBox.TabIndex = 16;
            // 
            // settingsPanel
            // 
            settingsPanel.BackColor = Color.FromArgb(43, 43, 43);
            settingsPanel.Controls.Add(label1);
            settingsPanel.Controls.Add(serverToPingTextBox);
            settingsPanel.Controls.Add(pingCountLabel);
            settingsPanel.Controls.Add(pingCountTextBox);
            settingsPanel.Controls.Add(secondsBetweenPingsLabel);
            settingsPanel.Controls.Add(secondsBetweenPingsTextBox);
            settingsPanel.Controls.Add(maxResponseTimeLabel);
            settingsPanel.Controls.Add(maxResponseTimeTextBox);
            settingsPanel.Controls.Add(serverToPingLabel);
            settingsPanel.Controls.Add(perfectThresholdLabel);
            settingsPanel.Controls.Add(perfectThresholdTextBox);
            settingsPanel.Controls.Add(goodThresholdLabel);
            settingsPanel.Controls.Add(goodThresholdTextBox);
            settingsPanel.Controls.Add(mediumThresholdLabel);
            settingsPanel.Controls.Add(mediumThresholdTextBox);
            settingsPanel.Controls.Add(applyChangesButton);
            settingsPanel.Location = new Point(12, 15);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(326, 316);
            settingsPanel.TabIndex = 0;
            settingsPanel.Paint += settingsPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 13.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(110, 14);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 17;
            label1.Text = "Parameters";
            // 
            // additionalPanel
            // 
            additionalPanel.BackColor = Color.FromArgb(43, 43, 43);
            additionalPanel.Controls.Add(configurationLabel);
            additionalPanel.Controls.Add(consoleOutput);
            additionalPanel.Location = new Point(12, 15);
            additionalPanel.Name = "additionalPanel";
            additionalPanel.Size = new Size(326, 316);
            additionalPanel.TabIndex = 0;
            additionalPanel.Visible = false;
            // 
            // consoleOutput
            // 
            consoleOutput.BackColor = Color.FromArgb(36, 36, 36);
            consoleOutput.BorderStyle = BorderStyle.None;
            consoleOutput.Font = new Font("Consolas", 9F);
            consoleOutput.ForeColor = Color.White;
            consoleOutput.Location = new Point(10, 41);
            consoleOutput.Name = "consoleOutput";
            consoleOutput.ReadOnly = true;
            consoleOutput.ScrollBars = RichTextBoxScrollBars.None;
            consoleOutput.Size = new Size(306, 264);
            consoleOutput.TabIndex = 1;
            consoleOutput.Text = "";
            // 
            // togglePanelsButton
            // 
            togglePanelsButton.BackColor = Color.FromArgb(31, 106, 165);
            togglePanelsButton.FlatStyle = FlatStyle.Popup;
            togglePanelsButton.ForeColor = SystemColors.Control;
            togglePanelsButton.Location = new Point(122, 2);
            togglePanelsButton.Name = "togglePanelsButton";
            togglePanelsButton.Size = new Size(108, 25);
            togglePanelsButton.TabIndex = 1;
            togglePanelsButton.Text = "Show console";
            togglePanelsButton.UseVisualStyleBackColor = false;
            togglePanelsButton.Click += TogglePanelsButton_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 342);
            Controls.Add(togglePanelsButton);
            Controls.Add(additionalPanel);
            Controls.Add(settingsPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            additionalPanel.ResumeLayout(false);
            additionalPanel.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Label configurationLabel;
        private Label consoleLabel;
        private Label pingCountLabel;
        private TextBox pingCountTextBox;
        private Label secondsBetweenPingsLabel;
        private TextBox secondsBetweenPingsTextBox;
        private Label maxResponseTimeLabel;
        private TextBox maxResponseTimeTextBox;
        private Label serverToPingLabel;
        private Label perfectThresholdLabel;
        private TextBox perfectThresholdTextBox;
        private Label goodThresholdLabel;
        private TextBox goodThresholdTextBox;
        private Label mediumThresholdLabel;
        private TextBox mediumThresholdTextBox;
        private Button applyChangesButton;
        private Button togglePanelsButton;
        private TextBox serverToPingTextBox;
        private Panel settingsPanel;
        private Panel additionalPanel;
        private RichTextBox consoleOutput;
        private Label label1;
    }
}
