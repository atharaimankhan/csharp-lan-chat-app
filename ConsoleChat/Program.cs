using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace ConsoleChat
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread Reciever = new Thread(reciever) { Name = "Reciever" };
            Thread.CurrentThread.Name = "Client";
            Reciever.Start();
            
            try
            {

                // Establish the remote endpoint  
                // for the socket. This example  
                // uses port 11111 on the local  
                // computer. 
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                Console.WriteLine(ipHost.HostName);
                //Console.WriteLine(ipHost.HostName);
                //Console.WriteLine(ipHost.AddressList[ipHost.AddressList.Length-1]);


                //NetworkInterface[] intf = NetworkInterface.GetAllNetworkInterfaces();
                //foreach (NetworkInterface device in intf)
                //{

                //    IPAddress ipv6Address = device.GetIPProperties().UnicastAddresses[0].Address; //This will give ipv6 address of certain adapter
                //    IPAddress ipv4Address = device.GetIPProperties().UnicastAddresses[1].Address; //This will give ipv4 address of certain adapter
                //    Console.WriteLine("IPV4 : " + ipv4Address);

                //}


                IPAddress MyIpAddr = ipHost.AddressList[ipHost.AddressList.Length - 1];
                Console.WriteLine("Your IP : " + MyIpAddr);

                Console.WriteLine("Enter ip address of device you want to connect: ");
                IPAddress ipAddr;
                if (IPAddress.TryParse(Console.ReadLine(), out ipAddr))
                {
                    IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 22222);
                    // Creation TCP/IP Socket using  
                    // Socket Class Costructor 
                    Socket sender = new Socket(ipAddr.AddressFamily,
                               SocketType.Stream, ProtocolType.Tcp);

                    try
                    {

                        // Connect Socket to the remote  
                        // endpoint using method Connect() 
                        sender.Connect(localEndPoint);

                        // We print EndPoint information  
                        // that we are connected
                        Console.WriteLine("Socket connected to -> {0} ",
                                      sender.RemoteEndPoint.ToString());

                        // Creation of messagge that 
                        // we will send to Server 
                        Console.WriteLine("..............CHAT.............");
                        
                        while (true)
                        {
                            Console.Write("\nYou\t->\t");
                            byte[] messageSent = Encoding.ASCII.GetBytes(Console.ReadLine() + "<EOF>");
                            int byteSent = sender.Send(messageSent);

                        }
                        // Close Socket using  
                        // the method Close() 
                        sender.Shutdown(SocketShutdown.Both);
                        sender.Close();
                    }


                    catch (ArgumentNullException ane)
                    {

                        Console.WriteLine("\nArgumentNullException : {0}", ane.ToString());
                    }

                    // Manage of Socket's Exceptions 
                    catch (SocketException se)
                    {

                        Console.WriteLine("\nSocketException : {0}", se.ToString());
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("\nUnexpected exception : {0}", e.ToString());
                    }

                }

            }

            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }


        private static void reciever()
        {

            Thread.Sleep(4000);




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

                    while (true)
                    {
                        string data = null;

                        byte[] bytes = new Byte[1024];

                        int numByte = clientSocket.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes,
                                                   0, numByte);

                        //if (data.IndexOf("<EOF>") > -1)
                        //    break;
                        Console.WriteLine("\n{1}\t->\t{0}", data.Substring(0, data.IndexOf("<EOF>")), clientSocket.RemoteEndPoint);
                        Console.Write("\nYou\t->\t");
                    }



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
