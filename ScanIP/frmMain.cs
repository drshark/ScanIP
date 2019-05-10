using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ScanIP
{
    public partial class frmMain : Form
    {
        #region Variable and Enum Declaration

        //Constant
        private const int mPING = 1;
        private const int mPORT = 2;
        private const int mPORTS = 1;
        private const int mRANGE = 2;


        private int ScanMethod;
        private int PortMethod;
        bool forceClose;
        bool Pause;
        int valMinC1 = 1, valMinC2 = 1, valMaxC1 = 1, valMaxC2 = 1;
        int valMinC3 = 1, valMinC4 = 1, valMaxC3 = 1, valMaxC4 = 1;
        int valMin, valMax;
        PortScanner ps;

        public enum butState : int
        {
            Stop = 0, Start = 1
        }

        #endregion

        #region Function

        public void WriteStatus(string info)
        {
            if (info != null)
                lblInfo.Text = info;
        }

        public void WriteList(string info)
        {
            if (info == null) return;

            //If items exceed the maxium value ...
            if (lstInfo.Items.Count > 32750)
                lstInfo.Items.Clear();
            //Add the info string to the list item object
            lstInfo.Items.Add(DateTime.Now.ToString("dd/MM/yy HH:mm") + " - " + info);
            //Select the last item written
            lstInfo.SelectedIndex = lstInfo.Items.Count - 1;
            //Call a refreh
            lstInfo.Refresh();
        }

        public void WriteRes(string info)
        {
            if (info == null) return;
            //If items exceed the maxium value ...
            if (lstRes.Items.Count > 32750)
                lstRes.Items.Clear();

            //Add the info string to the list item object
            lstRes.Items.Add(DateTime.Now.ToString("dd/MM/yy HH:mm") + " - " + info);
            //Select the last item written
            lstRes.SelectedIndex = lstRes.Items.Count - 1;
            //Call a refreh
            lstRes.Refresh();
        }

        public void ClearList()
        {
            //Clear the list item
            lstInfo.Items.Clear();
            lstInfo.Refresh();
        }

        public void ClearRes()
        {
            //Clear the list item
            lstRes.Items.Clear();
            lstRes.Refresh();
        }

        public void EnableButtons(butState What)
        {
            if (What == butState.Stop)
            {
                butStop.Enabled = true;
                butStart.Enabled = false;
                butPause.Enabled = true;
            }
            else
            {
                butStop.Enabled = false;
                butStart.Enabled = true;
                butPause.Enabled = false;
            }
        }

        private void SetMinMaxValue(string host)
        {
            bool[] attivi = { false, false, false, false };

            string ip = HashCheck(host, ref attivi);

            if (ip != host)
            {
                valMin = int.Parse(txtIPMin.Text);
                valMax = int.Parse(txtIPMax.Text);
            }

            if (attivi[0])
            {
                valMinC1 = valMin;
                valMaxC1 = valMax;
            }
            if (attivi[1])
            {
                valMinC2 = valMin;
                valMaxC2 = valMax;
            }
            if (attivi[2])
            {
                valMinC3 = valMin;
                valMaxC3 = valMax;
            }
            if (attivi[3])
            {
                valMinC4 = valMin;
                valMaxC4 = valMax;
            }
        }

        private string HashCheck(string ingresso, ref bool[] attivi)
        {
            string[] buff = ingresso.Split('.');
            string uscita = "";
            int c = 1;

            for (int i = 0; i < buff.Length; i++)
            {
                if (buff[i] == "#")
                {
                    attivi[i] = true;
                    uscita += "#" + Convert.ToString(i + 1);
                    c++;
                }
                else
                {
                    uscita += buff[i];
                }
                if (i < (buff.Length - 1)) uscita += ".";

            }

            return uscita;
        }

        public static int StringToInt(string pf)
        {
            return Convert.ToInt16(pf);
        }

        private bool CheckInput(ref int[] PortsList)
        {
            int number;            //For parse test
            bool result;

            //Check for IP address
            if (txtHost.Text.Length < 1)
            {
                MessageBox.Show("ADDRESS ERROR: please, enter a corret URL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //THIS CHECKS TO SEE IF IT THE timeout CAN BE PARSED OUT
            result = int.TryParse(txtTimeout.Text, out number);
            if (!result || (number < 1))
            {
                MessageBox.Show("TIMEOUT: the value (ms.) must be between 1 and 65535");
                return false;
            }

            if (ScanMethod == mPORT)
            {
                string[] temp;
                if (PortMethod == mRANGE)
                {
                    temp = txtPortRange.Text.Trim().Split('-');
                    if (temp.Length != 2)
                    {
                        MessageBox.Show("PORT RANGE: the range must be between 0 and 65535 separated by '-' character");
                        return false;
                    }
                    PortsList[0] = int.Parse(temp[0]);
                    PortsList[1] = int.Parse(temp[1]);
                }
                else
                {
                    char[] separator = { '.', ' ', ',', ';', ':' };
                    int c = 0;
                    temp = txtPortSpecifics.Text.Trim().Split(separator[c]);
                    //Minimun 2 values
                    while ((temp.Length < 2) && (c < (separator.Length - 1)))
                    {
                        c++;
                        temp = null;
                        temp = txtPortSpecifics.Text.Trim().Split(separator[c]);
                    }
                    try
                    {
                        PortsList = Array.ConvertAll(temp, new Converter<String, int>(StringToInt));
                    }
                    catch
                    {
                        MessageBox.Show("PORT RANGE: the range must be between 0 and 65535 separated by '-' character");
                        return false;
                    }
                }

                //THIS CHECKS TO SEE IF IT THE END PORT CAN BE PARSED OUT
                if (!result)
                {
                    MessageBox.Show("PORT END ERROR: the value must be between 0 and 65535");
                    return false;
                }
            }
            //I have to check min and max value only if user is using '#'
            if (txtHost.Text.IndexOf('#') >= 0)
            {
                result = int.TryParse(txtIPMin.Text, out number);
                if (!result || (number < 0) || (number > 255))
                {
                    MessageBox.Show("MIN IP: enter a value between 0 and 255");
                    return false;
                }

                result = int.TryParse(txtIPMax.Text, out number);
                if (!result || (number < 0) || (number > 255))
                {
                    MessageBox.Show("MAX IP: enter a value between 0 and 255");
                    return false;
                }
            }

            //All is ok!
            return true;
        }

        void SetStateGroup(bool enab)
        {
            if (enab)
            {
                grpAddress.Enabled = true;
                grpGeneral.Enabled = true;
                //Enable Port Scanner Options group only if the method ise selected
                if (ScanMethod == mPORT)
                    grpPortScanner.Enabled = true;
            }
            else
            {
                grpAddress.Enabled = false;
                grpGeneral.Enabled = false;
                grpPortScanner.Enabled = false;

            }
        }

        #endregion

        #region Form Event

        private void RadioTipo_Click(object sender, EventArgs e)
        {
            //Convert my object in a RadioButton
            RadioButton cont = Convert.ChangeType(sender, typeof(RadioButton)) as RadioButton;

            //Check which method user choosed and set it
            if (cont.Text.ToUpper() == "PING")
            {
                grpPortScanner.Enabled = false;
                ScanMethod = mPING;
            }
            else
            {
                grpPortScanner.Enabled = true;
                ScanMethod = mPORT;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set Form text with app name and version
            this.Text = "IpScan - v. " + Application.ProductVersion;
            //Set port range method as default
            radioPort1.Checked = true;
            radioPort1.PerformClick();
            //Set Ping method as default
            radioTipo1.Checked = true;
            radioTipo1.PerformClick();
            this.WriteStatus("Ready");
            txtTimeout.Text = "100";
            //Enabled the right button
            EnableButtons(butState.Start);
        }

        private void lstRes_DoubleClick(object sender, EventArgs e)
        {
            //Convert my object in a ListBox
            ListBox obj = Convert.ChangeType(sender, typeof(ListBox)) as ListBox;
            //I need minimum 1 item 
            if (obj.SelectedIndex < 0)
                return;
            // Place it  on the clipboard
            Clipboard.SetData(DataFormats.Text, (Object)obj.SelectedItem.ToString());
        }

        private void ButPause_Click(object sender, EventArgs e)
        {
            Pause = !Pause;
            if (Pause)
            {
                butPause.Text = "Resume";
                this.WriteList("Paused by user.");
            }
            else
            {
                butPause.Text = "Pause";
                this.WriteList("Resumed by user.");
            }
        }

        private void RadioPort_Click(object sender, EventArgs e)
        {
            //Convert my object in a RadioButton
            RadioButton cont = Convert.ChangeType(sender, typeof(RadioButton)) as RadioButton;

            //Check which port method user choosed and use it
            if (cont.Text.ToUpper().IndexOf("RANGE") < 0)
            {
                //Specific ports
                PortMethod = mPORTS;
                txtPortRange.Enabled = false;
                txtPortSpecifics.Enabled = true;
            }
            else
            {
                //Port range
                PortMethod = mRANGE;
                txtPortRange.Enabled = true;
                txtPortSpecifics.Enabled = false;
            }
        }

        private void ButExit_Click(object sender, EventArgs e)
        {
            this.WriteStatus("Closing...");
            if (ScanMethod == mPORT)
                ps.Stop();
            forceClose = true;
            Pause = false;
            Application.DoEvents();
            Application.Exit();
        }

        private void ButStart_Click(object sender, EventArgs e)
        {
            //string host = txtHost.Text;
            string host;
            int timeout;
            int[] listPorts = { -1, -1 };

            //Check if values are correct
            if (!CheckInput(ref listPorts))
                return;

            forceClose = false;
            Pause = false;

            //Set host address
            host = txtHost.Text;
            timeout = int.Parse(txtTimeout.Text);

            //Disable start button and enabled stop button
            EnableButtons(butState.Stop);

            //Clear the list items
            this.ClearList();
            this.ClearRes();

            string indirizzo;
            int controllati = 0, trovati = 0;

            Ping pingSender = new Ping();
            bool[] attivi = { false, false, false, false };

            string ip = HashCheck(host, ref attivi);

            SetMinMaxValue(host);

            SetStateGroup(false);

            if (ScanMethod == mPORT)
            {
                //All is ok, let's start!
                for (int c1 = valMinC1; c1 < (valMaxC1 + 1); c1++)
                {
                    for (int c2 = valMinC2; c2 < (valMaxC2 + 1); c2++)
                    {
                        for (int c3 = valMinC3; c3 < (valMaxC3 + 1); c3++)
                        {
                            for (int c4 = valMinC4; c4 < (valMaxC4 + 1); c4++)
                            {
                                if (attivi[0])
                                    indirizzo = ip.Replace("#1", Convert.ToString(c1));
                                else
                                    indirizzo = ip;
                                if (attivi[1]) indirizzo = indirizzo.Replace("#2", Convert.ToString(c2));
                                if (attivi[2]) indirizzo = indirizzo.Replace("#3", Convert.ToString(c3));
                                if (attivi[3]) indirizzo = indirizzo.Replace("#4", Convert.ToString(c4));
                                //DRS - debug
                                Console.WriteLine(indirizzo);

                                this.WriteList("Check ports for :" + indirizzo);
                                ps = new PortScanner(indirizzo, listPorts, PortMethod, timeout, this, true);
                                ps.Start();
                                controllati++;
                                //this.WriteStatus("Adresses checked " + Convert.ToString(controllati) + ".");
                                Application.DoEvents();
                                if (forceClose == true) break;

                                //Loop if called Pause
                                while (Pause == true)
                                {
                                    Application.DoEvents();
                                }
                            }
                            if (forceClose == true) break;
                        }
                        if (forceClose == true) break;
                    }
                    if (forceClose == true)
                    {
                        this.WriteList("Aborted by user.");
                        break;
                    }
                    this.WriteList("Done!");
                }
            }
            else
            {
                this.WriteList("Ping starded.");
                for (int c1 = valMinC1; c1 < (valMaxC1 + 1); c1++)
                {
                    for (int c2 = valMinC2; c2 < (valMaxC2 + 1); c2++)
                    {
                        for (int c3 = valMinC3; c3 < (valMaxC3 + 1); c3++)
                        {
                            for (int c4 = valMinC4; c4 < (valMaxC4 + 1); c4++)
                            {
                                if (attivi[0])
                                    indirizzo = ip.Replace("#1", Convert.ToString(c1));
                                else
                                    indirizzo = ip;
                                if (attivi[1]) indirizzo = indirizzo.Replace("#2", Convert.ToString(c2));
                                if (attivi[2]) indirizzo = indirizzo.Replace("#3", Convert.ToString(c3));
                                if (attivi[3]) indirizzo = indirizzo.Replace("#4", Convert.ToString(c4));
                                //DRS - debug
                                Console.WriteLine(indirizzo);

                                PingReply reply = pingSender.Send(indirizzo, timeout);
                                if (reply.Status == IPStatus.Success)
                                {
                                    this.WriteRes("IP: " + indirizzo + " - time: " + Convert.ToString(reply.RoundtripTime) + " ms." + reply.Buffer.Length);
                                    trovati++;
                                }
                                controllati++;
                                this.WriteStatus("Adresses checked " + Convert.ToString(controllati) + ".");
                                Application.DoEvents();
                                if (forceClose == true) break;

                                //Loop if called Pause
                                while (Pause == true)
                                {
                                    Application.DoEvents();
                                }
                            }
                            if (forceClose == true) break;
                        }
                        if (forceClose == true) break;
                    }
                    if (forceClose == true)
                    {
                        this.WriteList("Aborted by user.");
                        break;
                    }
                    this.WriteList("Done!");
                }
            }
            //It's over, so enable start button and groups 
            EnableButtons(butState.Start);
            SetStateGroup(true);
        }

        private void ButStop_Click(object sender, EventArgs e)
        {
            if (ScanMethod == mPORT)
                ps.Stop();
            forceClose = true;
            Pause = false;
            butPause.Text = "Pause";
            SetStateGroup(true);
        }

        #endregion

        public frmMain()
        {
            InitializeComponent();
        }                             
    }
}
