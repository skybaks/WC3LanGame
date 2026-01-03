namespace WC3LanGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            wc3VersionComboBox = new ComboBox();
            gameTypeComboBox = new ComboBox();
            hostLabel = new Label();
            gameLabel = new Label();
            versionLabel = new Label();
            runProxyButton = new Button();
            gameInfoTableLayoutPanel = new TableLayoutPanel();
            mapSizeValueLabel = new Label();
            mapSizeTitleLabel = new Label();
            gameTypeValueLabel = new Label();
            gameTypeTitleLabel = new Label();
            hostAddressValueLabel = new Label();
            gamePortTitleLabel = new Label();
            gamePortValueLabel = new Label();
            clientCountTitleLabel = new Label();
            clientCountValueLabel = new Label();
            playersCountTitleLabel = new Label();
            playersCountValueLabel = new Label();
            mapNameTitleLabel = new Label();
            mapNameValueLabel = new Label();
            gameNameTitleLabel = new Label();
            gameNameValueLabel = new Label();
            hostAddressTitleLabel = new Label();
            stopProxyButton = new Button();
            wc3ProcessRunningStatusLabel = new Label();
            scanningNetworkProgressBar = new ProgressBar();
            hostAddressComboBox = new ComboBox();
            scanningNetworkLabel = new Label();
            proxyActiveLabel = new Label();
            gameInfoTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // wc3VersionComboBox
            // 
            wc3VersionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            wc3VersionComboBox.Font = new Font("Segoe UI", 14F);
            wc3VersionComboBox.FormattingEnabled = true;
            wc3VersionComboBox.Location = new Point(101, 73);
            wc3VersionComboBox.Name = "wc3VersionComboBox";
            wc3VersionComboBox.Size = new Size(172, 33);
            wc3VersionComboBox.TabIndex = 2;
            // 
            // gameTypeComboBox
            // 
            gameTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gameTypeComboBox.Font = new Font("Segoe UI", 14F);
            gameTypeComboBox.FormattingEnabled = true;
            gameTypeComboBox.Location = new Point(101, 130);
            gameTypeComboBox.Name = "gameTypeComboBox";
            gameTypeComboBox.Size = new Size(172, 33);
            gameTypeComboBox.TabIndex = 3;
            // 
            // hostLabel
            // 
            hostLabel.AutoSize = true;
            hostLabel.Font = new Font("Segoe UI", 14F);
            hostLabel.Location = new Point(12, 12);
            hostLabel.Name = "hostLabel";
            hostLabel.Size = new Size(54, 25);
            hostLabel.TabIndex = 5;
            hostLabel.Text = "Host:";
            // 
            // gameLabel
            // 
            gameLabel.AutoSize = true;
            gameLabel.Font = new Font("Segoe UI", 14F);
            gameLabel.Location = new Point(12, 130);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(65, 25);
            gameLabel.TabIndex = 6;
            gameLabel.Text = "Game:";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Segoe UI", 14F);
            versionLabel.Location = new Point(12, 73);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(79, 25);
            versionLabel.TabIndex = 7;
            versionLabel.Text = "Version:";
            // 
            // runProxyButton
            // 
            runProxyButton.Font = new Font("Segoe UI", 16F);
            runProxyButton.Location = new Point(153, 183);
            runProxyButton.Name = "runProxyButton";
            runProxyButton.Size = new Size(120, 40);
            runProxyButton.TabIndex = 8;
            runProxyButton.Text = "Connect";
            runProxyButton.UseVisualStyleBackColor = true;
            runProxyButton.Click += runProxyButton_Click;
            // 
            // gameInfoTableLayoutPanel
            // 
            gameInfoTableLayoutPanel.ColumnCount = 2;
            gameInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            gameInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            gameInfoTableLayoutPanel.Controls.Add(mapSizeValueLabel, 1, 5);
            gameInfoTableLayoutPanel.Controls.Add(mapSizeTitleLabel, 0, 5);
            gameInfoTableLayoutPanel.Controls.Add(gameTypeValueLabel, 1, 2);
            gameInfoTableLayoutPanel.Controls.Add(gameTypeTitleLabel, 0, 2);
            gameInfoTableLayoutPanel.Controls.Add(hostAddressValueLabel, 1, 0);
            gameInfoTableLayoutPanel.Controls.Add(gamePortTitleLabel, 0, 1);
            gameInfoTableLayoutPanel.Controls.Add(gamePortValueLabel, 1, 1);
            gameInfoTableLayoutPanel.Controls.Add(clientCountTitleLabel, 0, 7);
            gameInfoTableLayoutPanel.Controls.Add(clientCountValueLabel, 1, 7);
            gameInfoTableLayoutPanel.Controls.Add(playersCountTitleLabel, 0, 6);
            gameInfoTableLayoutPanel.Controls.Add(playersCountValueLabel, 1, 6);
            gameInfoTableLayoutPanel.Controls.Add(mapNameTitleLabel, 0, 4);
            gameInfoTableLayoutPanel.Controls.Add(mapNameValueLabel, 1, 4);
            gameInfoTableLayoutPanel.Controls.Add(gameNameTitleLabel, 0, 3);
            gameInfoTableLayoutPanel.Controls.Add(gameNameValueLabel, 1, 3);
            gameInfoTableLayoutPanel.Controls.Add(hostAddressTitleLabel, 0, 0);
            gameInfoTableLayoutPanel.Location = new Point(322, 12);
            gameInfoTableLayoutPanel.Name = "gameInfoTableLayoutPanel";
            gameInfoTableLayoutPanel.RowCount = 8;
            gameInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            gameInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            gameInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            gameInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            gameInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            gameInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            gameInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            gameInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            gameInfoTableLayoutPanel.Size = new Size(291, 246);
            gameInfoTableLayoutPanel.TabIndex = 9;
            gameInfoTableLayoutPanel.Visible = false;
            // 
            // mapSizeValueLabel
            // 
            mapSizeValueLabel.AutoSize = true;
            mapSizeValueLabel.Font = new Font("Segoe UI", 12F);
            mapSizeValueLabel.Location = new Point(123, 150);
            mapSizeValueLabel.Name = "mapSizeValueLabel";
            mapSizeValueLabel.Size = new Size(16, 21);
            mapSizeValueLabel.TabIndex = 17;
            mapSizeValueLabel.Text = "-";
            // 
            // mapSizeTitleLabel
            // 
            mapSizeTitleLabel.AutoSize = true;
            mapSizeTitleLabel.Font = new Font("Segoe UI", 12F);
            mapSizeTitleLabel.Location = new Point(3, 150);
            mapSizeTitleLabel.Name = "mapSizeTitleLabel";
            mapSizeTitleLabel.Size = new Size(73, 21);
            mapSizeTitleLabel.TabIndex = 17;
            mapSizeTitleLabel.Text = "Map Size";
            // 
            // gameTypeValueLabel
            // 
            gameTypeValueLabel.AutoSize = true;
            gameTypeValueLabel.Font = new Font("Segoe UI", 12F);
            gameTypeValueLabel.Location = new Point(123, 60);
            gameTypeValueLabel.Name = "gameTypeValueLabel";
            gameTypeValueLabel.Size = new Size(16, 21);
            gameTypeValueLabel.TabIndex = 17;
            gameTypeValueLabel.Text = "-";
            // 
            // gameTypeTitleLabel
            // 
            gameTypeTitleLabel.AutoSize = true;
            gameTypeTitleLabel.Font = new Font("Segoe UI", 12F);
            gameTypeTitleLabel.Location = new Point(3, 60);
            gameTypeTitleLabel.Name = "gameTypeTitleLabel";
            gameTypeTitleLabel.Size = new Size(87, 21);
            gameTypeTitleLabel.TabIndex = 12;
            gameTypeTitleLabel.Text = "Game Type";
            // 
            // hostAddressValueLabel
            // 
            hostAddressValueLabel.AutoSize = true;
            hostAddressValueLabel.Font = new Font("Segoe UI", 12F);
            hostAddressValueLabel.Location = new Point(123, 0);
            hostAddressValueLabel.Name = "hostAddressValueLabel";
            hostAddressValueLabel.Size = new Size(16, 21);
            hostAddressValueLabel.TabIndex = 1;
            hostAddressValueLabel.Text = "-";
            // 
            // gamePortTitleLabel
            // 
            gamePortTitleLabel.AutoSize = true;
            gamePortTitleLabel.Font = new Font("Segoe UI", 12F);
            gamePortTitleLabel.Location = new Point(3, 30);
            gamePortTitleLabel.Name = "gamePortTitleLabel";
            gamePortTitleLabel.Size = new Size(83, 21);
            gamePortTitleLabel.TabIndex = 2;
            gamePortTitleLabel.Text = "Game Port";
            // 
            // gamePortValueLabel
            // 
            gamePortValueLabel.AutoSize = true;
            gamePortValueLabel.Font = new Font("Segoe UI", 12F);
            gamePortValueLabel.Location = new Point(123, 30);
            gamePortValueLabel.Name = "gamePortValueLabel";
            gamePortValueLabel.Size = new Size(16, 21);
            gamePortValueLabel.TabIndex = 3;
            gamePortValueLabel.Text = "-";
            // 
            // clientCountTitleLabel
            // 
            clientCountTitleLabel.AutoSize = true;
            clientCountTitleLabel.Font = new Font("Segoe UI", 12F);
            clientCountTitleLabel.Location = new Point(3, 210);
            clientCountTitleLabel.Name = "clientCountTitleLabel";
            clientCountTitleLabel.Size = new Size(57, 21);
            clientCountTitleLabel.TabIndex = 10;
            clientCountTitleLabel.Text = "Clients";
            // 
            // clientCountValueLabel
            // 
            clientCountValueLabel.AutoSize = true;
            clientCountValueLabel.Font = new Font("Segoe UI", 12F);
            clientCountValueLabel.Location = new Point(123, 210);
            clientCountValueLabel.Name = "clientCountValueLabel";
            clientCountValueLabel.Size = new Size(16, 21);
            clientCountValueLabel.TabIndex = 11;
            clientCountValueLabel.Text = "-";
            // 
            // playersCountTitleLabel
            // 
            playersCountTitleLabel.AutoSize = true;
            playersCountTitleLabel.Font = new Font("Segoe UI", 12F);
            playersCountTitleLabel.Location = new Point(3, 180);
            playersCountTitleLabel.Name = "playersCountTitleLabel";
            playersCountTitleLabel.Size = new Size(60, 21);
            playersCountTitleLabel.TabIndex = 8;
            playersCountTitleLabel.Text = "Players";
            // 
            // playersCountValueLabel
            // 
            playersCountValueLabel.AutoSize = true;
            playersCountValueLabel.Font = new Font("Segoe UI", 12F);
            playersCountValueLabel.Location = new Point(123, 180);
            playersCountValueLabel.Name = "playersCountValueLabel";
            playersCountValueLabel.Size = new Size(16, 21);
            playersCountValueLabel.TabIndex = 9;
            playersCountValueLabel.Text = "-";
            // 
            // mapNameTitleLabel
            // 
            mapNameTitleLabel.AutoSize = true;
            mapNameTitleLabel.Font = new Font("Segoe UI", 12F);
            mapNameTitleLabel.Location = new Point(3, 120);
            mapNameTitleLabel.Name = "mapNameTitleLabel";
            mapNameTitleLabel.Size = new Size(87, 21);
            mapNameTitleLabel.TabIndex = 6;
            mapNameTitleLabel.Text = "Map Name";
            // 
            // mapNameValueLabel
            // 
            mapNameValueLabel.AutoSize = true;
            mapNameValueLabel.Font = new Font("Segoe UI", 12F);
            mapNameValueLabel.Location = new Point(123, 120);
            mapNameValueLabel.Name = "mapNameValueLabel";
            mapNameValueLabel.Size = new Size(16, 21);
            mapNameValueLabel.TabIndex = 7;
            mapNameValueLabel.Text = "-";
            // 
            // gameNameTitleLabel
            // 
            gameNameTitleLabel.AutoSize = true;
            gameNameTitleLabel.Font = new Font("Segoe UI", 12F);
            gameNameTitleLabel.Location = new Point(3, 90);
            gameNameTitleLabel.Name = "gameNameTitleLabel";
            gameNameTitleLabel.Size = new Size(97, 21);
            gameNameTitleLabel.TabIndex = 4;
            gameNameTitleLabel.Text = "Game Name";
            // 
            // gameNameValueLabel
            // 
            gameNameValueLabel.AutoSize = true;
            gameNameValueLabel.Font = new Font("Segoe UI", 12F);
            gameNameValueLabel.Location = new Point(123, 90);
            gameNameValueLabel.Name = "gameNameValueLabel";
            gameNameValueLabel.Size = new Size(16, 21);
            gameNameValueLabel.TabIndex = 5;
            gameNameValueLabel.Text = "-";
            // 
            // hostAddressTitleLabel
            // 
            hostAddressTitleLabel.AutoSize = true;
            hostAddressTitleLabel.Font = new Font("Segoe UI", 12F);
            hostAddressTitleLabel.Location = new Point(3, 0);
            hostAddressTitleLabel.Name = "hostAddressTitleLabel";
            hostAddressTitleLabel.Size = new Size(102, 21);
            hostAddressTitleLabel.TabIndex = 0;
            hostAddressTitleLabel.Text = "Host Address";
            // 
            // stopProxyButton
            // 
            stopProxyButton.Font = new Font("Segoe UI", 16F);
            stopProxyButton.Location = new Point(12, 183);
            stopProxyButton.Name = "stopProxyButton";
            stopProxyButton.Size = new Size(120, 40);
            stopProxyButton.TabIndex = 10;
            stopProxyButton.Text = "Stop";
            stopProxyButton.UseVisualStyleBackColor = true;
            stopProxyButton.Visible = false;
            stopProxyButton.Click += stopProxyButton_Click;
            // 
            // wc3ProcessRunningStatusLabel
            // 
            wc3ProcessRunningStatusLabel.AutoSize = true;
            wc3ProcessRunningStatusLabel.Font = new Font("Segoe UI", 12F);
            wc3ProcessRunningStatusLabel.Location = new Point(12, 272);
            wc3ProcessRunningStatusLabel.Name = "wc3ProcessRunningStatusLabel";
            wc3ProcessRunningStatusLabel.Size = new Size(59, 21);
            wc3ProcessRunningStatusLabel.TabIndex = 12;
            wc3ProcessRunningStatusLabel.Text = "WC3 is";
            // 
            // scanningNetworkProgressBar
            // 
            scanningNetworkProgressBar.Location = new Point(138, 49);
            scanningNetworkProgressBar.Name = "scanningNetworkProgressBar";
            scanningNetworkProgressBar.Size = new Size(135, 19);
            scanningNetworkProgressBar.TabIndex = 13;
            // 
            // hostAddressComboBox
            // 
            hostAddressComboBox.Font = new Font("Segoe UI", 14F);
            hostAddressComboBox.FormattingEnabled = true;
            hostAddressComboBox.Location = new Point(101, 12);
            hostAddressComboBox.Name = "hostAddressComboBox";
            hostAddressComboBox.Size = new Size(172, 33);
            hostAddressComboBox.TabIndex = 14;
            hostAddressComboBox.Text = "10.8.0.14";
            // 
            // scanningNetworkLabel
            // 
            scanningNetworkLabel.AutoSize = true;
            scanningNetworkLabel.Font = new Font("Segoe UI", 10F);
            scanningNetworkLabel.Location = new Point(12, 48);
            scanningNetworkLabel.Name = "scanningNetworkLabel";
            scanningNetworkLabel.Size = new Size(122, 19);
            scanningNetworkLabel.TabIndex = 15;
            scanningNetworkLabel.Text = "Network scanning:";
            // 
            // proxyActiveLabel
            // 
            proxyActiveLabel.AutoSize = true;
            proxyActiveLabel.Font = new Font("Segoe UI", 14F);
            proxyActiveLabel.Location = new Point(410, 266);
            proxyActiveLabel.Name = "proxyActiveLabel";
            proxyActiveLabel.Size = new Size(136, 25);
            proxyActiveLabel.TabIndex = 17;
            proxyActiveLabel.Text = "Proxy is active!";
            proxyActiveLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WarcraftBackgroundImage;
            ClientSize = new Size(624, 321);
            Controls.Add(proxyActiveLabel);
            Controls.Add(scanningNetworkLabel);
            Controls.Add(hostAddressComboBox);
            Controls.Add(scanningNetworkProgressBar);
            Controls.Add(wc3ProcessRunningStatusLabel);
            Controls.Add(stopProxyButton);
            Controls.Add(gameInfoTableLayoutPanel);
            Controls.Add(runProxyButton);
            Controls.Add(versionLabel);
            Controls.Add(gameLabel);
            Controls.Add(hostLabel);
            Controls.Add(gameTypeComboBox);
            Controls.Add(wc3VersionComboBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "WC3 Lan Game";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            gameInfoTableLayoutPanel.ResumeLayout(false);
            gameInfoTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private ComboBox wc3VersionComboBox;
        private ComboBox gameTypeComboBox;
        private Label hostLabel;
        private Label gameLabel;
        private Label versionLabel;
        private Button runProxyButton;
        private TableLayoutPanel gameInfoTableLayoutPanel;
        private Label hostAddressTitleLabel;
        private Label hostAddressValueLabel;
        private Label gamePortTitleLabel;
        private Label gamePortValueLabel;
        private Label gameNameTitleLabel;
        private Label gameNameValueLabel;
        private Label mapNameTitleLabel;
        private Label mapNameValueLabel;
        private Label playersCountTitleLabel;
        private Label playersCountValueLabel;
        private Label clientCountTitleLabel;
        private Label clientCountValueLabel;
        private Button stopProxyButton;
        private Label wc3ProcessRunningStatusLabel;
        private ProgressBar scanningNetworkProgressBar;
        private ComboBox hostAddressComboBox;
        private Label scanningNetworkLabel;
        private Label mapSizeValueLabel;
        private Label mapSizeTitleLabel;
        private Label gameTypeValueLabel;
        private Label gameTypeTitleLabel;
        private Label proxyActiveLabel;
    }
}