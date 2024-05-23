
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
            SuspendLayout();
            // 
            // configurationLabel
            // 
            configurationLabel.AutoSize = true;
            configurationLabel.Font = new Font("Microsoft JhengHei", 13.25F, FontStyle.Bold);
            configurationLabel.ForeColor = SystemColors.Control;
            configurationLabel.Location = new Point(80, 6);
            configurationLabel.Name = "configurationLabel";
            configurationLabel.Size = new Size(132, 23);
            configurationLabel.TabIndex = 0;
            configurationLabel.Text = "Configuration";
            configurationLabel.Click += configurationLabel_Click;
            // 
            // pingCountLabel
            // 
            pingCountLabel.AutoSize = true;
            pingCountLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            pingCountLabel.ForeColor = SystemColors.Control;
            pingCountLabel.Location = new Point(12, 40);
            pingCountLabel.Name = "pingCountLabel";
            pingCountLabel.Size = new Size(76, 17);
            pingCountLabel.TabIndex = 1;
            pingCountLabel.Text = "Ping count:";
            pingCountLabel.Click += pingCountLabel_Click;
            // 
            // pingCountTextBox
            // 
            pingCountTextBox.Location = new Point(150, 37);
            pingCountTextBox.Name = "pingCountTextBox";
            pingCountTextBox.Size = new Size(129, 23);
            pingCountTextBox.TabIndex = 2;
            // 
            // secondsBetweenPingsLabel
            // 
            secondsBetweenPingsLabel.AutoSize = true;
            secondsBetweenPingsLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            secondsBetweenPingsLabel.ForeColor = SystemColors.Control;
            secondsBetweenPingsLabel.Location = new Point(12, 69);
            secondsBetweenPingsLabel.Name = "secondsBetweenPingsLabel";
            secondsBetweenPingsLabel.Size = new Size(130, 17);
            secondsBetweenPingsLabel.TabIndex = 3;
            secondsBetweenPingsLabel.Text = "Seconds in between:";
            secondsBetweenPingsLabel.Click += secondsBetweenPingsLabel_Click;
            // 
            // secondsBetweenPingsTextBox
            // 
            secondsBetweenPingsTextBox.Location = new Point(150, 66);
            secondsBetweenPingsTextBox.Name = "secondsBetweenPingsTextBox";
            secondsBetweenPingsTextBox.Size = new Size(129, 23);
            secondsBetweenPingsTextBox.TabIndex = 4;
            // 
            // maxResponseTimeLabel
            // 
            maxResponseTimeLabel.AutoSize = true;
            maxResponseTimeLabel.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxResponseTimeLabel.ForeColor = SystemColors.Control;
            maxResponseTimeLabel.Location = new Point(12, 98);
            maxResponseTimeLabel.Name = "maxResponseTimeLabel";
            maxResponseTimeLabel.Size = new Size(125, 17);
            maxResponseTimeLabel.TabIndex = 5;
            maxResponseTimeLabel.Text = "Max response time:";
            // 
            // maxResponseTimeTextBox
            // 
            maxResponseTimeTextBox.Location = new Point(150, 95);
            maxResponseTimeTextBox.Name = "maxResponseTimeTextBox";
            maxResponseTimeTextBox.Size = new Size(129, 23);
            maxResponseTimeTextBox.TabIndex = 6;
            // 
            // serverToPingLabel
            // 
            serverToPingLabel.AutoSize = true;
            serverToPingLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            serverToPingLabel.ForeColor = SystemColors.Control;
            serverToPingLabel.Location = new Point(12, 127);
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
            perfectThresholdLabel.Location = new Point(12, 156);
            perfectThresholdLabel.Name = "perfectThresholdLabel";
            perfectThresholdLabel.Size = new Size(114, 17);
            perfectThresholdLabel.TabIndex = 9;
            perfectThresholdLabel.Text = "Perfect threshold:";
            // 
            // perfectThresholdTextBox
            // 
            perfectThresholdTextBox.Location = new Point(150, 153);
            perfectThresholdTextBox.Name = "perfectThresholdTextBox";
            perfectThresholdTextBox.Size = new Size(129, 23);
            perfectThresholdTextBox.TabIndex = 10;
            // 
            // goodThresholdLabel
            // 
            goodThresholdLabel.AutoSize = true;
            goodThresholdLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            goodThresholdLabel.ForeColor = SystemColors.Control;
            goodThresholdLabel.Location = new Point(12, 185);
            goodThresholdLabel.Name = "goodThresholdLabel";
            goodThresholdLabel.Size = new Size(106, 17);
            goodThresholdLabel.TabIndex = 11;
            goodThresholdLabel.Text = "Good threshold:";
            // 
            // goodThresholdTextBox
            // 
            goodThresholdTextBox.Location = new Point(150, 182);
            goodThresholdTextBox.Name = "goodThresholdTextBox";
            goodThresholdTextBox.Size = new Size(129, 23);
            goodThresholdTextBox.TabIndex = 12;
            // 
            // mediumThresholdLabel
            // 
            mediumThresholdLabel.AutoSize = true;
            mediumThresholdLabel.Font = new Font("Microsoft JhengHei UI", 9.75F);
            mediumThresholdLabel.ForeColor = SystemColors.Control;
            mediumThresholdLabel.Location = new Point(12, 214);
            mediumThresholdLabel.Name = "mediumThresholdLabel";
            mediumThresholdLabel.Size = new Size(123, 17);
            mediumThresholdLabel.TabIndex = 13;
            mediumThresholdLabel.Text = "Medium threshold:";
            // 
            // mediumThresholdTextBox
            // 
            mediumThresholdTextBox.Location = new Point(150, 211);
            mediumThresholdTextBox.Name = "mediumThresholdTextBox";
            mediumThresholdTextBox.Size = new Size(129, 23);
            mediumThresholdTextBox.TabIndex = 14;
            // 
            // applyChangesButton
            // 
            applyChangesButton.Font = new Font("Microsoft JhengHei UI", 9.75F);
            applyChangesButton.ForeColor = SystemColors.Control;
            applyChangesButton.Location = new Point(80, 242);
            applyChangesButton.Name = "applyChangesButton";
            applyChangesButton.Size = new Size(131, 26);
            applyChangesButton.TabIndex = 15;
            applyChangesButton.Text = "Apply changes";
            applyChangesButton.UseVisualStyleBackColor = true;
            applyChangesButton.Click += SaveButton_Click;
            // 
            // serverToPingTextBox
            // 
            serverToPingTextBox.Location = new Point(150, 124);
            serverToPingTextBox.Name = "serverToPingTextBox";
            serverToPingTextBox.Size = new Size(129, 23);
            serverToPingTextBox.TabIndex = 16;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 276);
            Controls.Add(serverToPingTextBox);
            Controls.Add(configurationLabel);
            Controls.Add(pingCountLabel);
            Controls.Add(pingCountTextBox);
            Controls.Add(secondsBetweenPingsLabel);
            Controls.Add(secondsBetweenPingsTextBox);
            Controls.Add(maxResponseTimeLabel);
            Controls.Add(maxResponseTimeTextBox);
            Controls.Add(serverToPingLabel);
            Controls.Add(perfectThresholdLabel);
            Controls.Add(perfectThresholdTextBox);
            Controls.Add(goodThresholdLabel);
            Controls.Add(goodThresholdTextBox);
            Controls.Add(mediumThresholdLabel);
            Controls.Add(mediumThresholdTextBox);
            Controls.Add(applyChangesButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label configurationLabel;
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
        private TextBox serverToPingTextBox;
    }
}
