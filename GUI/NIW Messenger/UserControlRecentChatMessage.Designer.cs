namespace NIW_Messenger
{
    partial class UserControlRecentChatMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelCountNew;
            this.pictureBoxPofilePhoto = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            labelCountNew = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPofilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountNew
            // 
            labelCountNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            labelCountNew.AutoSize = true;
            labelCountNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(73)))), ((int)(((byte)(51)))));
            labelCountNew.ForeColor = System.Drawing.Color.White;
            labelCountNew.Location = new System.Drawing.Point(306, 29);
            labelCountNew.Name = "labelCountNew";
            labelCountNew.Size = new System.Drawing.Size(13, 13);
            labelCountNew.TabIndex = 3;
            labelCountNew.Text = "1";
            // 
            // pictureBoxPofilePhoto
            // 
            this.pictureBoxPofilePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxPofilePhoto.Image = global::NIW_Messenger.Properties.Resources.icons8_female_profile_80;
            this.pictureBoxPofilePhoto.ImageLocation = "";
            this.pictureBoxPofilePhoto.Location = new System.Drawing.Point(10, 1);
            this.pictureBoxPofilePhoto.Name = "pictureBoxPofilePhoto";
            this.pictureBoxPofilePhoto.Size = new System.Drawing.Size(56, 64);
            this.pictureBoxPofilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPofilePhoto.TabIndex = 0;
            this.pictureBoxPofilePhoto.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(87, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(204, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Label Name";
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMessage.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(88, 38);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(203, 23);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Label Recent Message";
            // 
            // UserControlRecentChatMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(labelCountNew);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxPofilePhoto);
            this.Name = "UserControlRecentChatMessage";
            this.Size = new System.Drawing.Size(346, 68);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPofilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPofilePhoto;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMessage;
    }
}
