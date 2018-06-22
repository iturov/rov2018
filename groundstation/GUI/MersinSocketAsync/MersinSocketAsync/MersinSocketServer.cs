using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MersinSocketAsync
{
    public class MersinSocketServer
    {
        IPAddress mIP;
        int mPort;
        TcpListener mTCPListener;   // To create server

        List<TcpClient> mClients;

        DateTime logtime;

        public MersinSocketServer() // Define Constructor
        {
            mClients = new List<TcpClient>(); // Start listening for incoming connection
        }

        public bool Keeprunning { get; set; }


        public async void StartListeningForIncomingConnection(IPAddress ipaddr = null, int port = 1864)
        {
            if (ipaddr == null)
            {
                ipaddr = IPAddress.Any;
            }

            mIP = ipaddr;
            mPort = port;

            logtime = DateTime.Now;
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
            {
                file.WriteLine("\n" + logtime.ToString() + string.Format(" IP Address: {0} - Port : {1}", mIP.ToString(), mPort));
            }

            mTCPListener = new TcpListener(mIP, mPort);

            try
            {
                mTCPListener.Start();
                Keeprunning = true;

                while (Keeprunning)
                {
                    var returnedByAccept = await mTCPListener.AcceptTcpClientAsync();
                    mClients.Add(returnedByAccept);

                    logtime = DateTime.Now;
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
                    {
                        file.WriteLine("\n" + logtime.ToString() + string.Format(" Client connected succesfully, count: {0} - {1}", mClients.Count, returnedByAccept.Client.RemoteEndPoint));
                    }

                    TakeCareOfTcpClient(returnedByAccept); // TCP client object
                }
            }
            catch (Exception ex)
            {
                logtime = DateTime.Now;
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
                {
                    file.WriteLine("\n" + logtime.ToString() + ex.ToString());
                }
            }
        }

        public void StopServer()
        {
            try
            {
                mTCPListener.Stop();

                foreach (TcpClient item in mClients)
                {
                    item.Close();
                }
            }
            catch (Exception ex)
            {
                logtime = DateTime.Now;
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
                {
                    file.WriteLine("\n" + logtime.ToString() + ex.ToString());
                }
            }
        }

        private async void TakeCareOfTcpClient(TcpClient paramClient) // Changed from returnedByAccept to paramClient
        {
            // Define
            NetworkStream stream = null;
            StreamReader reader = null;

            try
            {
                stream = paramClient.GetStream();
                reader = new StreamReader(stream);

                char[] buff = new char[64];

                //Ready to read from clients
                while (Keeprunning)
                {
                    logtime = DateTime.Now;
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
                    {
                        file.WriteLine("\n" + logtime.ToString() + " Ready to read");
                    }


                    int nRet = await reader.ReadAsync(buff, 0, buff.Length); // Store the returned value

                    logtime = DateTime.Now;
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
                    {
                        file.WriteLine("\n" + logtime.ToString() + " Returned: " + nRet.ToString());
                    }


                    if (nRet == 0)
                    {
                        RemoveClient(paramClient);
                        logtime = DateTime.Now;
                        using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
                        {
                            file.WriteLine("\n" + logtime.ToString() + " Socket disconnected");
                        }
                        break;
                    }
                    string recvData = new string(buff);

                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"C:\Users\Public\ROV\recv.txt", true))
                    {
                        file.WriteLine("\n" + recvData); // Save received data
                    }
                    logtime = DateTime.Now;
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
                    {
                        file.WriteLine("\n" + logtime.ToString() + " Received: " + recvData);
                    }

                    Array.Clear(buff, 0, buff.Length); //Clear buffer 
                }
            }
            catch (Exception ex)
            {
                RemoveClient(paramClient);
                logtime = DateTime.Now;
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
                {
                    file.WriteLine("\n" + logtime.ToString() + ex.ToString());
                }
            }
        }

        private void RemoveClient(TcpClient paramClient)
        {
            if (mClients.Contains(paramClient))
            {
                mClients.Remove(paramClient);
                logtime = DateTime.Now;
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
                {
                    file.WriteLine("\n" + logtime.ToString() + string.Format(" Client removed, count {0}", mClients.Count));
                }
            }
        }

        public async void SendTo(string leMessage)
        {
            if (string.IsNullOrEmpty(leMessage))
            {
                return;
            }
            try
            {
                byte[] buffMessage = Encoding.ASCII.GetBytes(leMessage);
                foreach (TcpClient c in mClients)
                {
                    c.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
                }

                logtime = DateTime.Now;
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\ROV\logs.txt", true))
                {
                    file.WriteLine("\n" + logtime.ToString() + " Transmitted: " + leMessage);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

