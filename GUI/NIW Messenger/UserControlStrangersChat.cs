using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NIW_Messenger
{
    public partial class UserControlStrangersChat : UserControl
    {
        public UserControlStrangersChat()
        {
            InitializeComponent();
            this.label_Invalid.Visible = false;
            richTextBoxChat = new System.Windows.Forms.RichTextBox();
            richTextBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBoxChat.Dock = System.Windows.Forms.DockStyle.Top;
            richTextBoxChat.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            richTextBoxChat.Location = new System.Drawing.Point(0, 0);
            richTextBoxChat.Name = "richTextBoxChat";
            richTextBoxChat.ReadOnly = true;
            richTextBoxChat.Size = new System.Drawing.Size(360, 391);
            richTextBoxChat.TabIndex = 0;
            richTextBoxChat.Text = "";
            richTextBoxChat.TextChanged += new System.EventHandler(this.RichTextBoxChat_TextChanged);
            Controls.Add(richTextBoxChat);
        }

        static private System.Windows.Forms.RichTextBox richTextBoxChat;

        private void PictureBoxSend_Click(object sender, EventArgs e)
        {
            IPAddress ipAddr;
            if (IPAddress.TryParse(textBoxIpAddress.Text, out ipAddr))
            {

                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 22222);
                // Creation TCP/IP Socket using  
                // Socket Class Costructor 
                Socket _sender = new Socket(ipAddr.AddressFamily,
                           SocketType.Stream, ProtocolType.Tcp);

                try
                {

                    // Connect Socket to the remote  
                    // endpoint using method Connect()
                    this.label_Invalid.Text = "Waiting......";
                    this.label_Invalid.Visible = true;
                    this.Update();

                    _sender.Connect(localEndPoint);
                    this.label_Invalid.Visible = false;
                    
                    // We print EndPoint information  
                    // that we are connected
                    //Console.WriteLine("Socket connected to -> {0} ",
                    //              sender.RemoteEndPoint.ToString());

                    //// Creation of messagge that 
                    //// we will send to Server 
                    //Console.WriteLine("..............CHAT.............");


                    byte[] messageSent = Encoding.ASCII.GetBytes(textBoxMessage.Text + "<EOF>");
                    int byteSent = _sender.Send(messageSent);

                    // Close Socket using  
                    // the method Close() 
                    _sender.Shutdown(SocketShutdown.Both);
                    _sender.Close();
                    richTextBoxChat.SelectionColor = Color.FromArgb(12, 124, 89);
                    richTextBoxChat.SelectedText = "YOu: ";
                    richTextBoxChat.SelectionColor = Color.Black;
                    richTextBoxChat.SelectedText = this.textBoxMessage.Text + "\n";
                    textBoxMessage.Text = "";

                }


                catch (ArgumentNullException ane)
                {
                    this.label_Invalid.Text = "Invalid / Error";
                    this.label_Invalid.Visible = true;
                }

                // Manage of Socket's Exceptions 
                catch (SocketException se)
                {
                    this.label_Invalid.Text = "Invalid / Error";
                    this.label_Invalid.Visible = true;

                }

                catch (Exception E)
                {
                    this.label_Invalid.Text = "Invalid / Error";
                    this.label_Invalid.Visible = true;

                }
                this.Update();
            }
            
        }

        private void RichTextBoxChat_TextChanged(object sender, EventArgs e)
        {
            richTextBoxChat.SelectionStart = richTextBoxChat.Text.Length;
            // scroll it automatically
            richTextBoxChat.ScrollToCaret();
            
        }

        private void TextBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PictureBoxSend_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        static public void getMessage(string sender , string msg)
        {
            //msg = msg.Substring(0, msg.IndexOf("<EOF>"));
            //if (sender.Contains(":"))
            //{
            //    sender = sender.Substring(0, sender.IndexOf(":"));

            //}
            if (richTextBoxChat.InvokeRequired)
            {
                var d = new SafeCallDelegate(getMessage);
                richTextBoxChat.Invoke(d, new object[] { sender, msg });
            }
            else
            {
                richTextBoxChat.SelectionColor = Color.FromArgb(214, 73, 51);
                richTextBoxChat.SelectedText = sender + ": ";
                richTextBoxChat.SelectionColor = Color.Black;
                richTextBoxChat.SelectedText = msg + "\n";
                
            }


        }

        

        Thread RecieverForStrangers = new Thread(AcceptFromStrangers) { Name = "RecieverForStrangers" };

        public void StartReciever()
        {
            RecieverForStrangers.Start();
        }
        public void StopReciever()
        {
            RecieverForStrangers.Abort();
         
        }

        private delegate void SafeCallDelegate(string sender, string msg);


        

        static private void AcceptFromStrangers()
        {
            // Establish the local endpoint  
            // for the socket. Dns.GetHostName 
            // returns the name of the host  
            // running the application. 
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[ipHost.AddressList.Length - 1];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 22222);

            // Creation TCP/IP Socket using  
            // Socket Class Costructor 
            Socket listener = new Socket(ipAddr.AddressFamily,
                         SocketType.Stream, ProtocolType.Tcp);

            try
            {

                // Using Bind() method we associate a 
                // network address to the Server Socket 
                // All client that will connect to this  
                // Server Socket must know this network 
                // Address 
                listener.Bind(localEndPoint);

                // Using Listen() method we create  
                // the Client list that will want 
                // to connect to Server 
                listener.Listen(20);

                while (true)
                {

                    // Suspend while waiting for 
                    // incoming connection Using  
                    // Accept() method the server  
                    // will accept connection of client 
                    Socket clientSocket = listener.Accept();

                    // Data buffer 


                    //var childSocketThread = new Thread(() =>
                    //{
                    //    byte[] data = new byte[100];
                    //    int size = client.Receive(data);
                    //    Console.WriteLine("Recieved data: ");
                    //    for (int i = 0; i < size; i++)
                    //        Console.Write(Convert.ToChar(data[i]));

                    //    Console.WriteLine();

                    //    client.Close();
                    //});
                    //childSocketThread.Start();

                    string msg = null;

                    byte[] bytes = new Byte[1024];

                    int numByte = clientSocket.Receive(bytes);

                    msg += Encoding.ASCII.GetString(bytes,
                                               0, numByte);

                    string sender = clientSocket.RemoteEndPoint.ToString();
                    sender = sender.Substring(0, sender.IndexOf(":"));

                    msg = msg.Substring(0, msg.IndexOf("<EOF>"));

                    getMessage(sender, msg);

                    //Thread th = new Thread(() => RecieveFromStrangers(clientSocket, richTextBoxChat));
                    //th.Start();

                    // Close client Socket using the 
                    // Close() method. After closing, 
                    // we can use the closed Socket  
                    // for a new Client Connection 
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }


    }
}
