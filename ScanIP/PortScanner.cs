using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using System.Windows.Forms;

namespace ScanIP
{
    class PortScanner
    {

        #region Variable declaration

        private string host;
        private PortList portList;
        private bool turnOff = true;
        private int count = 0;
        public int tcpTimeout;
        private frmMain mainForm;
        private bool stopScan;

        #endregion

        private class isTcpPortOpen
        {
            public TcpClient MainClient { get; set; }
            public bool tcpOpen { get; set; }
        }

        public void Stop()
        {
            stopScan = true;
        }

        public PortScanner(string host, int[] ports, int port_method, int timeout, frmMain who, bool multi)
        {
            this.host = host;
            this.mainForm = who;

            portList = new PortList(ports, port_method);
            tcpTimeout = timeout;
        }

        public void Start()
        {
            stopScan = false;
            RunScanTcp();
        }

        public void RunScanTcp()
        {

            int port;

            //while there are more ports to scan 
            while (((port = portList.NextPort()) != -1) && (stopScan == false))
            {
                count = port;

                Thread.Sleep(1); //lets be a good citizen to the cpu
                Application.DoEvents();

                mainForm.WriteStatus("Address: " + host + " - Current Port Count : " + count.ToString());
                try
                {
                    Connect(host, port, tcpTimeout);
                }
                catch
                {
                    continue;
                }
                mainForm.WriteRes("IP: " + host + " - TCP Port " + port + " is open");
                try
                {
                    //grabs the banner / header info etc..
                    mainForm.WriteList(BannerGrab(host, port, tcpTimeout));
                }
                catch (Exception ex)
                {
                    mainForm.WriteList("Could not retrieve the Banner ::Original Error = " + ex.Message);
                }
                string webpageTitle = GetPageTitle("http://" + host + ":" + port.ToString());

                if (!string.IsNullOrWhiteSpace(webpageTitle))
                {
                    //this gets the html title of the webpage
                    mainForm.WriteList("Webpage Title = " + webpageTitle + "Found @ :: " + "http://" + host + ":" + port.ToString());
                }
                else
                {
                    mainForm.WriteList("Maybe A Login popup or a Service Login Found @ :: " + host + ":" + port.ToString());
                }
            }


            if (turnOff == true)
            {

                turnOff = false;
                if (stopScan == false)
                    mainForm.WriteList("Port scan complete.");
                else
                    mainForm.WriteList("Aborted by user.");
            }

        }
        //method for returning tcp client connected or not connected
        public TcpClient Connect(string hostName, int port, int timeout)
        {
            var newClient = new TcpClient();

            var state = new isTcpPortOpen
            {
                MainClient = newClient,
                tcpOpen = true
            };

            IAsyncResult ar = newClient.BeginConnect(hostName, port, AsyncCallback, state);
            state.tcpOpen = ar.AsyncWaitHandle.WaitOne(timeout, false);

            if (state.tcpOpen == false || newClient.Connected == false)
            {
                throw new Exception();

            }
            return newClient;
        }

        //method for Grabbing a webpage banner / header information
        public string BannerGrab(string hostName, int port, int timeout)
        {
            var newClient = new TcpClient(hostName, port);


            newClient.SendTimeout = timeout;
            newClient.ReceiveTimeout = timeout;
            NetworkStream ns = newClient.GetStream();
            StreamWriter sw = new StreamWriter(ns);

            //sw.Write("GET / HTTP/1.1\r\n\r\n");

            sw.Write("HEAD / HTTP/1.1\r\n\r\n"
                + "Connection: Closernrn");

            sw.Flush();

            byte[] bytes = new byte[2048];
            int bytesRead = ns.Read(bytes, 0, bytes.Length);
            string response = Encoding.ASCII.GetString(bytes, 0, bytesRead);

            return response;
        }


        //async callback for tcp clients
        void AsyncCallback(IAsyncResult asyncResult)
        {
            var state = (isTcpPortOpen)asyncResult.AsyncState;
            TcpClient client = state.MainClient;

            try
            {
                client.EndConnect(asyncResult);
            }
            catch
            {
                return;
            }

            if (client.Connected && state.tcpOpen)
            {
                return;
            }

            client.Close();
        }

        static string GetPageTitle(string link)
        {
            try
            {
                WebClient x = new WebClient();
                string sourcedata = x.DownloadString(link);
                string getValueTitle = Regex.Match(sourcedata, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;

                return getValueTitle;

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Could not connect. Error:" + ex.Message);
                Console.ResetColor();
                return "";
            }


        }

    }
}
