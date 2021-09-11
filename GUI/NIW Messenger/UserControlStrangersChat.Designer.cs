namespace NIW_Messenger
{
    partial class UserControlStrangersChat
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.pictureBoxSend = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Invalid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.Location = new System.Drawing.Point(64, 449);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(213, 27);
            this.textBoxMessage.TabIndex = 1;
            this.textBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMessage_KeyDown);
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Location = new System.Drawing.Point(64, 420);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(213, 20);
            this.textBoxIpAddress.TabIndex = 2;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.ForeColor = System.Drawing.Color.White;
            this.labelTo.Location = new System.Drawing.Point(38, 423);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "To";
            // 
            // pictureBoxSend
            // 
            this.pictureBoxSend.Image = global::NIW_Messenger.Properties.Resources.icons8_email_send_96;
            this.pictureBoxSend.ImageLocation = "";
            this.pictureBoxSend.Location = new System.Drawing.Point(292, 434);
            this.pictureBoxSend.Name = "pictureBoxSend";
            this.pictureBoxSend.Size = new System.Drawing.Size(52, 52);
            this.pictureBoxSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSend.TabIndex = 4;
            this.pictureBoxSend.TabStop = false;
            this.pictureBoxSend.Click += new System.EventHandler(this.PictureBoxSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message";
            // 
            // label_Invalid
            // 
            this.label_Invalid.AutoSize = true;
            this.label_Invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label_Invalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(73)))), ((int)(((byte)(51)))));
            this.label_Invalid.Location = new System.Drawing.Point(141, 400);
            this.label_Invalid.Name = "label_Invalid";
            this.label_Invalid.Size = new System.Drawing.Size(86, 13);
            this.label_Invalid.TabIndex = 6;
            this.label_Invalid.Text = "Invalid / Error";
            this.label_Invalid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlStrangersChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.label_Invalid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSend);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.textBoxIpAddress);
            this.Controls.Add(this.textBoxMessage);
            this.Name = "UserControlStrangersChat";
            this.Size = new System.Drawing.Size(360, 512);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.PictureBox pictureBoxSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Invalid;
        
    }
}
