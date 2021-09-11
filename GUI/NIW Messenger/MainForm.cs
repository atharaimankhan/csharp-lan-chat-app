using NIW_Messenger.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIW_Messenger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        public static bool test;

        private void PictureBoxClose_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

        private void PictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            this.pictureBoxClose.Image = Resources.icons8_close_window_100;
        }

        private void PictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxClose.Image = Resources.icons8_close_window_64 ;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void Label_NiwMessenger_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureBoxAppIcon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        bool isOptionDown = false;
        bool isSearchDown = false;
        private void PictureBoxOptions_Click(object sender, EventArgs e)
        {
            if (isOptionDown == false)
            {
                isOptionDown = true;
                this.flowLayoutPanelOptions.Visible = true;
            }
            else
            {
                this.flowLayoutPanelOptions.Visible = false;
                isOptionDown = false;
            }

        }

        private UserControlCustomLabel cl1 = new UserControlCustomLabel("New Chat");
        private UserControlCustomLabel cl2 = new UserControlCustomLabel("Settings");



        private void MainForm_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanelOptions.Controls.Add(cl1);
            this.flowLayoutPanelOptions.Controls.Add(cl2);
            this.flowLayoutPanelOptions.Visible = false;
            this.textBoxSearch.Visible = false;
            cl1.Mouse_Click += Cl1_Click;
            this.StrangersChat.Visible = false;
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress MyIpAddr = ipHost.AddressList[ipHost.AddressList.Length - 1];
            this.label_ip_address.Text = "Your IP : " + MyIpAddr.ToString();
            this.StrangersChat.StartReciever();

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // MainForm
        //    // 
        //    this.ClientSize = new System.Drawing.Size(274, 253);
        //    this.Name = "MainForm";
        //    this.ResumeLayout(false);

        //}

        private void Cl1_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanelOptions.Visible = false;
            isOptionDown = false;

        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            this.textBoxSearch.BackColor = Color.White;
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            this.textBoxSearch.BackColor = Color.FromArgb(186, 193, 184);
        }

        enum SelectedInterface
        {
            Friends,
            Strangers,
        }

        SelectedInterface SI = SelectedInterface.Friends;

        private void LabelStrangers_Click(object sender, EventArgs e)
        {
            SI = SelectedInterface.Strangers;
            pictureBoxBottomLine.Location = new Point(178, 34);
            this.labelFriends.ForeColor = Color.DimGray;
            this.labelStrangers.ForeColor = Color.White;
            StrangersChat.Visible = true;
            RecentChats.Visible = false;
        }

        private void LabelFriends_Click(object sender, EventArgs e)
        {
            SI = SelectedInterface.Friends;
            pictureBoxBottomLine.Location = new Point(0, 34);
            this.labelStrangers.ForeColor = Color.DimGray;
            this.labelFriends.ForeColor = Color.White;
            RecentChats.Visible = true;
            StrangersChat.Visible = false;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        

        private void PictureBoxSearch_Click(object sender, EventArgs e)
        {
            if(isSearchDown == false)
            {
                this.textBoxSearch.Visible = true;
                this.label_ip_address.Visible = false;
                isSearchDown = true;
            }
            else
            {
                this.textBoxSearch.Visible = false;
                this.label_ip_address.Visible = true;
                isSearchDown = false;
            }

        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {

        }
    }
}
