using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIW_Messenger
{
    public partial class UserControlCustomLabel : UserControl
    {
        public UserControlCustomLabel(string s)
        {
            InitializeComponent();
            text = s;
            //_backColor = BackColor;
        }

        public event EventHandler Mouse_Click;

        private string _text;
        //private Color _backColor;


        protected virtual void onMouseClick(EventArgs e)
        {
            Mouse_Click?.Invoke(this, e);
        }


        [Category ("Custom Props")]
        public string text {
            get { return _text;  }
            set { _text = labelText.Text = value; }
        }

        private void UserControlCustomLabel_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void UserControlCustomLabel_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.White;
            this.onMouseClick(EventArgs.Empty);
        }

        private void LabelText_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void LabelText_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.White;
            this.onMouseClick(EventArgs.Empty);
        }

        //[Category("Custom Props")]
        //public Color backColor
        //{
        //    get { return _backColor; }
        //    set { _backColor = this.BackColor = this.labelText.BackColor = value; }
        //}



        //private void UserControlCustomLabel_MouseHover(object sender, EventArgs e)
        //{
        //    this.BackColor = Color.LightGray;
        //}

        //private void UserControlCustomLabel_MouseLeave(object sender, EventArgs e)
        //{
        //    this.BackColor = Color.White;
        //}

        //private void LabelText_MouseHover(object sender, EventArgs e)
        //{
        //    this.BackColor = Color.LightGray;
        //}

        //private void LabelText_MouseLeave(object sender, EventArgs e)
        //{
        //    this.BackColor = Color.White;
        //}
    }
}
