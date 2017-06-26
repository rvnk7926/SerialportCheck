//////////////////////////////////////////////////////////////////////////////
//                               COPYRIGHT                                  //
//                      2017.05.16. Done by William.                        //
//  This program can detective your SERIAL PORT and make connection.        //
//  The ListBox will be clear after received 100 of data.                   //
//  You can reconnect after disconnect, but sometimes will get error.       //
//  Pls let me know when it happens.                                        //
//////////////////////////////////////////////////////////////////////////////  

using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialportCheck
{
    public partial class Form1 : Form
    {
        string[] ports = SerialPort.GetPortNames();
        Lib lib = new Lib();

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        #region ----Init----

        void Init()
        {
            ComboBox[] cbSP = new ComboBox[4] { cbSPname1, cbSPname2, cbSPname3, cbSPname4 };
            ComboBox[] cbBAU = new ComboBox[4] { cbBau1, cbBau2, cbBau3, cbBau4 };
            ComboBox[] cbEOS = new ComboBox[4] { cbEOS1, cbEOS2, cbEOS3, cbEOS4 };
            TextBox[] tb = new TextBox[4] { textBox1, textBox2, textBox3, textBox4 };

            if (ports.Length > 0)
            {
                foreach (string port in ports)
                    for (int i = 0; i < 4; i++)
                    {
                        cbSP[i].Items.Clear();
                        cbSP[i].Items.Add(port);
                    }
            }
            for (int i = 0; i < 4; i++)
            {
                cbSP[i].SelectedIndex = 0;
                cbBAU[i].SelectedIndex = 2;
                cbEOS[i].SelectedIndex = 3;
                tb[i].Enabled = false;
            }
        }

        private void cbSPname1_DropDown(object sender, EventArgs e)
        {
            if (cbSPname1.SelectedIndex == -1)
            {
                cbSPname1.SelectedIndex = 0;
            }
        }

        private void cbSPname2_DropDown(object sender, EventArgs e)
        {
            if (cbSPname2.SelectedIndex == -1)
            {
                cbSPname2.SelectedIndex = 0;
            }
        }

        private void cbSPname3_DropDown(object sender, EventArgs e)
        {
            if (cbSPname3.SelectedIndex == -1)
            {
                cbSPname3.SelectedIndex = 0;
            }
        }

        private void cbSPname4_DropDown(object sender, EventArgs e)
        {
            if (cbSPname4.SelectedIndex == -1)
            {
                cbSPname4.SelectedIndex = 0;
            }
        }

        private void cbBau1_DropDownClosed(object sender, EventArgs e)
        {
            if (cbBau1.SelectedIndex == -1)
            {
                //cbBau1.Items.Insert(0, "BaudRate");
                cbBau1.SelectedIndex = 0;
            }
        }

        private void cbBau2_DropDownClosed(object sender, EventArgs e)
        {
            if (cbBau2.SelectedIndex == -1)
            {
                cbBau2.Items.Insert(0, "BaudRate");
                cbBau2.SelectedIndex = 0;
            }
        }

        private void cbBau3_DropDownClosed(object sender, EventArgs e)
        {
            if (cbBau3.SelectedIndex == -1)
            {
                cbBau3.Items.Insert(0, "BaudRate");
                cbBau3.SelectedIndex = 0;
            }
        }

        private void cbBau4_DropDownClosed(object sender, EventArgs e)
        {
            if (cbBau4.SelectedIndex == -1)
            {
                cbBau4.Items.Insert(0, "BaudRate");
                cbBau4.SelectedIndex = 0;
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSP1.Checked) textBox1.Enabled = false;
            else if (rbMT1.Checked) textBox1.Enabled = true;
            if (rbSP2.Checked) textBox2.Enabled = false;
            else if (rbMT2.Checked) textBox2.Enabled = true;
            if (rbSP3.Checked) textBox3.Enabled = false;
            else if (rbMT3.Checked) textBox3.Enabled = true;
            if (rbSP4.Checked) textBox4.Enabled = false;
            else if (rbMT4.Checked) textBox4.Enabled = true;
        }

        #endregion

        #region ----Serial Port----

        #region ----SP1----

        private void btnSP1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    if (cbSPname1.Text != "")
                        serialPort1.PortName = cbSPname1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cbBau1.SelectedItem.ToString());
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    serialPort1.Open();
                    lbSP1.Items.Add("Connect!!");
                    btnSP1.Enabled = false;
                }
            }
            catch (Exception)
            {
                serialPort1.Close();
                serialPort1.Dispose();
                lbSP1.Items.Add("Disconnect!!");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int count1 = 0;
            int len = serialPort1.BytesToRead;
            char[] Rec_buffer = new char[len];
            if (len > 0)
                serialPort1.Read(Rec_buffer, 0, len);
            string str1 = new string(Rec_buffer).Trim();
            Invoke(new Action(
                    () =>
                    {
                        lbSP1.Items.Add(str1);
                        lbSP1.SelectedIndex = lbSP1.Items.Count - 1;
                        count1++;
                        if (count1 == 100)
                        {
                            lbSP1.Items.Clear();
                            count1 = 0;
                        }
                    }));
        }

        private void btnSP1_dis_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                serialPort1.Close();
                serialPort1.Dispose();
                Invoke(new Action(
                    () =>
                    {
                        btnSP1.Enabled = true;
                        lbSP1.Items.Clear();
                        lbSP1.Items.Add("Disconnect!!");
                    }));
            }
            catch { }
        }
        #endregion

        #region ----SP2----
        private void btnSP2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort2.IsOpen)
                {
                    if (cbSPname2.Text != "")
                        serialPort2.PortName = cbSPname2.Text;
                    serialPort2.BaudRate = Convert.ToInt32(cbBau2.Text);
                    serialPort2.DataReceived += new SerialDataReceivedEventHandler(serialPort2_DataReceived);
                    serialPort2.Open();
                    btnSP2.Enabled = false;
                }
            }
            catch (Exception)
            {
                serialPort2.Close();
                serialPort2.Dispose();
            }
        }
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int count2 = 0; string str2 = "";
            try
            {
                str2 = serialPort2.ReadLine();
                Invoke(new Action(
                    () =>
                    {
                        lbSP2.Items.Add(str2);
                        lbSP2.SelectedIndex = lbSP2.Items.Count - 1;
                        count2++;
                        if (count2 == 100)
                        {
                            lbSP2.Items.Clear();
                            count2 = 0;
                        }
                    }
                    ));
            }
            catch (Exception)
            {
                str2 = "";
                serialPort2.Close();
                serialPort2.Dispose();
            }
        }
        private void btnSP2_dis_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort2.DiscardInBuffer();
                serialPort2.DiscardOutBuffer();
                serialPort2.Close();
                serialPort2.Dispose();
                Invoke(new Action(
                    () =>
                    {
                        btnSP2.Enabled = true;
                        lbSP2.Items.Clear();
                    }));
            }
            catch { }
        }
        #endregion

        #region ----SP3----
        private void btnSP3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort3.IsOpen)
                {
                    if (cbSPname3.Text != "")
                        serialPort3.PortName = cbSPname3.Text;
                    serialPort3.BaudRate = Convert.ToInt32(cbBau3.Text);
                    serialPort3.DataReceived += new SerialDataReceivedEventHandler(serialPort3_DataReceived);
                    serialPort3.Open();
                    btnSP3.Enabled = false;
                }
            }
            catch (Exception)
            {
                serialPort3.Close();
                serialPort3.Dispose();
            }
        }
        private void serialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int count3 = 0; string str3 = "";
            try
            {
                str3 = serialPort3.ReadLine();
                Invoke(new Action(
                    () =>
                    {
                        lbSP3.Items.Add(str3);
                        lbSP3.SelectedIndex = lbSP3.Items.Count - 1;
                        count3++;
                        if (count3 == 100)
                        {
                            lbSP3.Items.Clear();
                            count3 = 0;
                        }
                    }
                    ));
            }
            catch (Exception)
            {
                str3 = "";
                serialPort3.Close();
                serialPort3.Dispose();
            }
        }
        private void btnSP3_dis_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort3.DiscardInBuffer();
                serialPort3.DiscardOutBuffer();
                serialPort3.Close();
                serialPort3.Dispose();
                Invoke(new Action(
                    () =>
                    {
                        btnSP3.Enabled = true;
                        lbSP3.Items.Clear();
                    }));
            }
            catch { }
        }
        #endregion

        #region ----SP4----
        private void btnSP4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort4.IsOpen)
                {
                    if (cbSPname4.Text != "")
                        serialPort4.PortName = cbSPname4.Text;
                    serialPort4.BaudRate = Convert.ToInt32(cbBau4.Text);
                    serialPort4.DataReceived += new SerialDataReceivedEventHandler(serialPort4_DataReceived);
                    serialPort4.Open();
                    btnSP4.Enabled = false;
                }
            }
            catch (Exception)
            {
                serialPort4.Close();
                serialPort4.Dispose();
            }
        }
        private void serialPort4_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int count4 = 0; string str4 = "";
            try
            {
                str4 = serialPort4.ReadLine();
                Invoke(new Action(
                    () =>
                    {
                        lbSP4.Items.Add(str4);
                        lbSP4.SelectedIndex = lbSP4.Items.Count - 1;
                        count4++;
                        if (count4 == 100)
                        {
                            lbSP4.Items.Clear();
                            count4 = 0;
                        }
                    }
                    ));
            }
            catch (Exception)
            {
                str4 = "";
                serialPort4.Close();
                serialPort4.Dispose();
            }
        }
        private void btnSP4_dis_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort4.DiscardInBuffer();
                serialPort4.DiscardOutBuffer();
                serialPort4.Close();
                serialPort4.Dispose();
                Invoke(new Action(
                    () =>
                    {
                        btnSP4.Enabled = true;
                        lbSP4.Items.Clear();
                    }));
            }
            catch { }
        }
        #endregion

        #endregion

        #region ----Send----

        private void btnSend1_Click(object sender, EventArgs e)
        {
            serialPort1.Write(lib.cmd(textBox1.Text.ToString(), cbEOS1.SelectedIndex));
        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            serialPort2.Write(lib.cmd(textBox2.Text.ToString(), cbEOS2.SelectedIndex));
        }

        private void btnSend3_Click(object sender, EventArgs e)
        {
            serialPort3.Write(lib.cmd(textBox3.Text.ToString(), cbEOS3.SelectedIndex));
        }

        private void btnSend4_Click(object sender, EventArgs e)
        {
            serialPort4.Write(lib.cmd(textBox4.Text.ToString(), cbEOS4.SelectedIndex));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSend1.PerformClick();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSend2.PerformClick();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSend3.PerformClick();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSend4.PerformClick();
        }

        #endregion
    }
}