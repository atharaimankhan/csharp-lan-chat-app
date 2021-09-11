namespace NIW_Messenger
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label_NiwMessenger = new System.Windows.Forms.Label();
            this.pictureBoxAppIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.label_ip_address = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.pictureBoxOptions = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStrangers = new System.Windows.Forms.Label();
            this.pictureBoxBottomLine = new System.Windows.Forms.PictureBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.RecentChats = new NIW_Messenger.UserControlRecentChats();
            this.StrangersChat = new NIW_Messenger.UserControlStrangersChat();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAppIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottomLine)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.panelTitleBar.Controls.Add(this.label_NiwMessenger);
            this.panelTitleBar.Controls.Add(this.pictureBoxAppIcon);
            this.panelTitleBar.Controls.Add(this.pictureBoxClose);
            this.panelTitleBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(360, 37);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // label_NiwMessenger
            // 
            this.label_NiwMessenger.AutoSize = true;
            this.label_NiwMessenger.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NiwMessenger.ForeColor = System.Drawing.SystemColors.Control;
            this.label_NiwMessenger.Location = new System.Drawing.Point(54, 9);
            this.label_NiwMessenger.Name = "label_NiwMessenger";
            this.label_NiwMessenger.Size = new System.Drawing.Size(121, 20);
            this.label_NiwMessenger.TabIndex = 2;
            this.label_NiwMessenger.Text = "NIW Messenger";
            this.label_NiwMessenger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_NiwMessenger_MouseDown);
            // 
            // pictureBoxAppIcon
            // 
            this.pictureBoxAppIcon.Image = global::NIW_Messenger.Properties.Resources.icons8_whatsapp_80;
            this.pictureBoxAppIcon.ImageLocation = "";
            this.pictureBoxAppIcon.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxAppIcon.Name = "pictureBoxAppIcon";
            this.pictureBoxAppIcon.Size = new System.Drawing.Size(27, 29);
            this.pictureBoxAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAppIcon.TabIndex = 1;
            this.pictureBoxAppIcon.TabStop = false;
            this.pictureBoxAppIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxAppIcon_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::NIW_Messenger.Properties.Resources.icons8_close_window_64;
            this.pictureBoxClose.ImageLocation = "";
            this.pictureBoxClose.Location = new System.Drawing.Point(328, 4);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(26, 29);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
            this.pictureBoxClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxClose_MouseClick);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.PictureBoxClose_MouseLeave);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.PictureBoxClose_MouseHover);
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuBar.Controls.Add(this.label_ip_address);
            this.panelMenuBar.Controls.Add(this.textBoxSearch);
            this.panelMenuBar.Controls.Add(this.pictureBoxSearch);
            this.panelMenuBar.Controls.Add(this.pictureBoxFriends);
            this.panelMenuBar.Controls.Add(this.pictureBoxOptions);
            this.panelMenuBar.Controls.Add(this.pictureBoxProfilePhoto);
            this.panelMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuBar.Location = new System.Drawing.Point(0, 37);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(360, 53);
            this.panelMenuBar.TabIndex = 1;
            // 
            // label_ip_address
            // 
            this.label_ip_address.AutoSize = true;
            this.label_ip_address.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label_ip_address.ForeColor = System.Drawing.SystemColors.Control;
            this.label_ip_address.Location = new System.Drawing.Point(110, 15);
            this.label_ip_address.Name = "label_ip_address";
            this.label_ip_address.Size = new System.Drawing.Size(102, 20);
            this.label_ip_address.TabIndex = 3;
            this.label_ip_address.Text = "192.168.10.2";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(193)))), ((int)(((byte)(184)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.textBoxSearch.Location = new System.Drawing.Point(106, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(168, 25);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = global::NIW_Messenger.Properties.Resources.icons8_search_144;
            this.pictureBoxSearch.ImageLocation = "";
            this.pictureBoxSearch.Location = new System.Drawing.Point(69, 4);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(28, 45);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 6;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.PictureBoxSearch_Click);
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Image = global::NIW_Messenger.Properties.Resources.icons8_contacts_144;
            this.pictureBoxFriends.ImageLocation = "";
            this.pictureBoxFriends.Location = new System.Drawing.Point(285, 3);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(33, 44);
            this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFriends.TabIndex = 5;
            this.pictureBoxFriends.TabStop = false;
            // 
            // pictureBoxOptions
            // 
            this.pictureBoxOptions.Image = global::NIW_Messenger.Properties.Resources.icons8_menu_vertical_96;
            this.pictureBoxOptions.ImageLocation = "";
            this.pictureBoxOptions.Location = new System.Drawing.Point(319, 3);
            this.pictureBoxOptions.Name = "pictureBoxOptions";
            this.pictureBoxOptions.Size = new System.Drawing.Size(29, 44);
            this.pictureBoxOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOptions.TabIndex = 4;
            this.pictureBoxOptions.TabStop = false;
            this.pictureBoxOptions.Click += new System.EventHandler(this.PictureBoxOptions_Click);
            // 
            // pictureBoxProfilePhoto
            // 
            this.pictureBoxProfilePhoto.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.pictureBoxProfilePhoto.Image = global::NIW_Messenger.Properties.Resources.icons8_circled_user_male_skin_type_3_80;
            this.pictureBoxProfilePhoto.ImageLocation = "";
            this.pictureBoxProfilePhoto.Location = new System.Drawing.Point(18, 2);
            this.pictureBoxProfilePhoto.Name = "pictureBoxProfilePhoto";
            this.pictureBoxProfilePhoto.Size = new System.Drawing.Size(39, 49);
            this.pictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfilePhoto.TabIndex = 3;
            this.pictureBoxProfilePhoto.TabStop = false;
            // 
            // flowLayoutPanelOptions
            // 
            this.flowLayoutPanelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelOptions.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelOptions.Location = new System.Drawing.Point(223, 91);
            this.flowLayoutPanelOptions.Name = "flowLayoutPanelOptions";
            this.flowLayoutPanelOptions.Size = new System.Drawing.Size(136, 180);
            this.flowLayoutPanelOptions.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelStrangers);
            this.panel1.Controls.Add(this.pictureBoxBottomLine);
            this.panel1.Controls.Add(this.labelFriends);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 38);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // labelStrangers
            // 
            this.labelStrangers.Font = new System.Drawing.Font("Jokerman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrangers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelStrangers.Location = new System.Drawing.Point(178, 7);
            this.labelStrangers.Name = "labelStrangers";
            this.labelStrangers.Size = new System.Drawing.Size(175, 25);
            this.labelStrangers.TabIndex = 2;
            this.labelStrangers.Text = "Strangers";
            this.labelStrangers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStrangers.Click += new System.EventHandler(this.LabelStrangers_Click);
            // 
            // pictureBoxBottomLine
            // 
            this.pictureBoxBottomLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.pictureBoxBottomLine.Location = new System.Drawing.Point(0, 34);
            this.pictureBoxBottomLine.Name = "pictureBoxBottomLine";
            this.pictureBoxBottomLine.Size = new System.Drawing.Size(175, 10);
            this.pictureBoxBottomLine.TabIndex = 1;
            this.pictureBoxBottomLine.TabStop = false;
            // 
            // labelFriends
            // 
            this.labelFriends.Font = new System.Drawing.Font("Jokerman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.ForeColor = System.Drawing.Color.White;
            this.labelFriends.Location = new System.Drawing.Point(0, 7);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(175, 25);
            this.labelFriends.TabIndex = 0;
            this.labelFriends.Text = "Friends";
            this.labelFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFriends.Click += new System.EventHandler(this.LabelFriends_Click);
            // 
            // RecentChats
            // 
            this.RecentChats.BackColor = System.Drawing.Color.DarkRed;
            this.RecentChats.Location = new System.Drawing.Point(0, 416);
            this.RecentChats.Name = "RecentChats";
            this.RecentChats.Size = new System.Drawing.Size(360, 224);
            this.RecentChats.TabIndex = 6;
            // 
            // StrangersChat
            // 
            this.StrangersChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.StrangersChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StrangersChat.Location = new System.Drawing.Point(0, 128);
            this.StrangersChat.Name = "StrangersChat";
            this.StrangersChat.Size = new System.Drawing.Size(360, 512);
            this.StrangersChat.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(193)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(360, 640);
            this.Controls.Add(this.flowLayoutPanelOptions);
            this.Controls.Add(this.RecentChats);
            this.Controls.Add(this.StrangersChat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuBar);
            this.Controls.Add(this.panelTitleBar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAppIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelMenuBar.ResumeLayout(false);
            this.panelMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottomLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBoxAppIcon;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label_NiwMessenger;
        private System.Windows.Forms.Panel panelMenuBar;
        private System.Windows.Forms.PictureBox pictureBoxProfilePhoto;
        private System.Windows.Forms.PictureBox pictureBoxOptions;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStrangers;
        private System.Windows.Forms.PictureBox pictureBoxBottomLine;
        private System.Windows.Forms.Label labelFriends;
        private UserControlStrangersChat StrangersChat;
        private UserControlRecentChats RecentChats;
        private System.Windows.Forms.Label label_ip_address;
    }
}

