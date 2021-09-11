namespace NIW_Messenger
{
    partial class UserControlCustomLabel
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
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText.AutoEllipsis = true;
            this.labelText.Font = new System.Drawing.Font("Georgia", 10F);
            this.labelText.Location = new System.Drawing.Point(13, 12);
            this.labelText.Margin = new System.Windows.Forms.Padding(3);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(123, 17);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Label Text";
            this.labelText.UseMnemonic = false;
            this.labelText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelText_MouseDown);
            this.labelText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelText_MouseUp);
            // 
            // UserControlCustomLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelText);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlCustomLabel";
            this.Size = new System.Drawing.Size(150, 43);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControlCustomLabel_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControlCustomLabel_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelText;
    }
}
