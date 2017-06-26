namespace SerialportCheck
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbSP4 = new System.Windows.Forms.ListBox();
            this.lbSP3 = new System.Windows.Forms.ListBox();
            this.lbSP2 = new System.Windows.Forms.ListBox();
            this.btnSP1_dis = new System.Windows.Forms.Button();
            this.btnSP1 = new System.Windows.Forms.Button();
            this.btnSP2 = new System.Windows.Forms.Button();
            this.btnSP2_dis = new System.Windows.Forms.Button();
            this.btnSP3 = new System.Windows.Forms.Button();
            this.btnSP3_dis = new System.Windows.Forms.Button();
            this.btnSP4 = new System.Windows.Forms.Button();
            this.btnSP4_dis = new System.Windows.Forms.Button();
            this.cbSPname1 = new System.Windows.Forms.ComboBox();
            this.cbBau1 = new System.Windows.Forms.ComboBox();
            this.cbSPname2 = new System.Windows.Forms.ComboBox();
            this.cbBau2 = new System.Windows.Forms.ComboBox();
            this.cbSPname3 = new System.Windows.Forms.ComboBox();
            this.cbBau3 = new System.Windows.Forms.ComboBox();
            this.cbSPname4 = new System.Windows.Forms.ComboBox();
            this.cbBau4 = new System.Windows.Forms.ComboBox();
            this.lbSP1 = new System.Windows.Forms.ListBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.btnSend3 = new System.Windows.Forms.Button();
            this.btnSend4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rbSP1 = new System.Windows.Forms.RadioButton();
            this.rbMT1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rbSP2 = new System.Windows.Forms.RadioButton();
            this.rbMT2 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.rbSP3 = new System.Windows.Forms.RadioButton();
            this.rbMT3 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rbSP4 = new System.Windows.Forms.RadioButton();
            this.rbMT4 = new System.Windows.Forms.RadioButton();
            this.cbEOS1 = new System.Windows.Forms.ComboBox();
            this.cbEOS2 = new System.Windows.Forms.ComboBox();
            this.cbEOS3 = new System.Windows.Forms.ComboBox();
            this.cbEOS4 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort4
            // 
            this.serialPort4.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort4_DataReceived);
            // 
            // serialPort3
            // 
            this.serialPort3.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort3_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 20;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.lbSP4, 12, 11);
            this.tableLayoutPanel2.Controls.Add(this.lbSP3, 2, 11);
            this.tableLayoutPanel2.Controls.Add(this.lbSP2, 12, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSP1_dis, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnSP1, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnSP2, 10, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnSP2_dis, 10, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnSP3, 0, 16);
            this.tableLayoutPanel2.Controls.Add(this.btnSP3_dis, 0, 18);
            this.tableLayoutPanel2.Controls.Add(this.btnSP4, 10, 16);
            this.tableLayoutPanel2.Controls.Add(this.btnSP4_dis, 10, 18);
            this.tableLayoutPanel2.Controls.Add(this.cbSPname1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbBau1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbSPname2, 10, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbBau2, 10, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbSPname3, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.cbBau3, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.cbSPname4, 10, 12);
            this.tableLayoutPanel2.Controls.Add(this.cbBau4, 10, 13);
            this.tableLayoutPanel2.Controls.Add(this.lbSP1, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSend1, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSend2, 18, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSend3, 8, 10);
            this.tableLayoutPanel2.Controls.Add(this.btnSend4, 18, 10);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 12, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 12, 10);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 10, 10);
            this.tableLayoutPanel2.Controls.Add(this.cbEOS1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbEOS2, 10, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbEOS3, 0, 14);
            this.tableLayoutPanel2.Controls.Add(this.cbEOS4, 10, 14);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 20;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(852, 621);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbSP4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.lbSP4, 8);
            this.lbSP4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSP4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSP4.FormattingEnabled = true;
            this.lbSP4.ItemHeight = 23;
            this.lbSP4.Location = new System.Drawing.Point(507, 344);
            this.lbSP4.Name = "lbSP4";
            this.tableLayoutPanel2.SetRowSpan(this.lbSP4, 9);
            this.lbSP4.Size = new System.Drawing.Size(342, 274);
            this.lbSP4.TabIndex = 27;
            // 
            // lbSP3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.lbSP3, 8);
            this.lbSP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSP3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSP3.FormattingEnabled = true;
            this.lbSP3.ItemHeight = 23;
            this.lbSP3.Location = new System.Drawing.Point(87, 344);
            this.lbSP3.Name = "lbSP3";
            this.tableLayoutPanel2.SetRowSpan(this.lbSP3, 9);
            this.lbSP3.Size = new System.Drawing.Size(330, 274);
            this.lbSP3.TabIndex = 26;
            // 
            // lbSP2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.lbSP2, 8);
            this.lbSP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSP2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSP2.FormattingEnabled = true;
            this.lbSP2.ItemHeight = 23;
            this.lbSP2.Location = new System.Drawing.Point(507, 34);
            this.lbSP2.Name = "lbSP2";
            this.tableLayoutPanel2.SetRowSpan(this.lbSP2, 9);
            this.lbSP2.Size = new System.Drawing.Size(342, 273);
            this.lbSP2.TabIndex = 25;
            // 
            // btnSP1_dis
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSP1_dis, 2);
            this.btnSP1_dis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSP1_dis.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSP1_dis.Location = new System.Drawing.Point(3, 251);
            this.btnSP1_dis.Name = "btnSP1_dis";
            this.tableLayoutPanel2.SetRowSpan(this.btnSP1_dis, 2);
            this.btnSP1_dis.Size = new System.Drawing.Size(78, 56);
            this.btnSP1_dis.TabIndex = 9;
            this.btnSP1_dis.Text = "Disconnect";
            this.btnSP1_dis.UseVisualStyleBackColor = true;
            this.btnSP1_dis.Click += new System.EventHandler(this.btnSP1_dis_Click);
            // 
            // btnSP1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSP1, 2);
            this.btnSP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSP1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSP1.Location = new System.Drawing.Point(3, 189);
            this.btnSP1.Name = "btnSP1";
            this.tableLayoutPanel2.SetRowSpan(this.btnSP1, 2);
            this.btnSP1.Size = new System.Drawing.Size(78, 56);
            this.btnSP1.TabIndex = 8;
            this.btnSP1.Text = "Connect";
            this.btnSP1.UseVisualStyleBackColor = true;
            this.btnSP1.Click += new System.EventHandler(this.btnSP1_Click);
            // 
            // btnSP2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSP2, 2);
            this.btnSP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSP2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSP2.Location = new System.Drawing.Point(423, 189);
            this.btnSP2.Name = "btnSP2";
            this.tableLayoutPanel2.SetRowSpan(this.btnSP2, 2);
            this.btnSP2.Size = new System.Drawing.Size(78, 56);
            this.btnSP2.TabIndex = 10;
            this.btnSP2.Text = "Connect";
            this.btnSP2.UseVisualStyleBackColor = true;
            this.btnSP2.Click += new System.EventHandler(this.btnSP2_Click);
            // 
            // btnSP2_dis
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSP2_dis, 2);
            this.btnSP2_dis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSP2_dis.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSP2_dis.Location = new System.Drawing.Point(423, 251);
            this.btnSP2_dis.Name = "btnSP2_dis";
            this.tableLayoutPanel2.SetRowSpan(this.btnSP2_dis, 2);
            this.btnSP2_dis.Size = new System.Drawing.Size(78, 56);
            this.btnSP2_dis.TabIndex = 11;
            this.btnSP2_dis.Text = "Disconnect";
            this.btnSP2_dis.UseVisualStyleBackColor = true;
            this.btnSP2_dis.Click += new System.EventHandler(this.btnSP2_dis_Click);
            // 
            // btnSP3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSP3, 2);
            this.btnSP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSP3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSP3.Location = new System.Drawing.Point(3, 499);
            this.btnSP3.Name = "btnSP3";
            this.tableLayoutPanel2.SetRowSpan(this.btnSP3, 2);
            this.btnSP3.Size = new System.Drawing.Size(78, 56);
            this.btnSP3.TabIndex = 12;
            this.btnSP3.Text = "Connect";
            this.btnSP3.UseVisualStyleBackColor = true;
            this.btnSP3.Click += new System.EventHandler(this.btnSP3_Click);
            // 
            // btnSP3_dis
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSP3_dis, 2);
            this.btnSP3_dis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSP3_dis.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSP3_dis.Location = new System.Drawing.Point(3, 561);
            this.btnSP3_dis.Name = "btnSP3_dis";
            this.tableLayoutPanel2.SetRowSpan(this.btnSP3_dis, 2);
            this.btnSP3_dis.Size = new System.Drawing.Size(78, 57);
            this.btnSP3_dis.TabIndex = 13;
            this.btnSP3_dis.Text = "Disconnect";
            this.btnSP3_dis.UseVisualStyleBackColor = true;
            this.btnSP3_dis.Click += new System.EventHandler(this.btnSP3_dis_Click);
            // 
            // btnSP4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSP4, 2);
            this.btnSP4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSP4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSP4.Location = new System.Drawing.Point(423, 499);
            this.btnSP4.Name = "btnSP4";
            this.tableLayoutPanel2.SetRowSpan(this.btnSP4, 2);
            this.btnSP4.Size = new System.Drawing.Size(78, 56);
            this.btnSP4.TabIndex = 14;
            this.btnSP4.Text = "Connect";
            this.btnSP4.UseVisualStyleBackColor = true;
            this.btnSP4.Click += new System.EventHandler(this.btnSP4_Click);
            // 
            // btnSP4_dis
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSP4_dis, 2);
            this.btnSP4_dis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSP4_dis.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSP4_dis.Location = new System.Drawing.Point(423, 561);
            this.btnSP4_dis.Name = "btnSP4_dis";
            this.tableLayoutPanel2.SetRowSpan(this.btnSP4_dis, 2);
            this.btnSP4_dis.Size = new System.Drawing.Size(78, 57);
            this.btnSP4_dis.TabIndex = 15;
            this.btnSP4_dis.Text = "Disconnect";
            this.btnSP4_dis.UseVisualStyleBackColor = true;
            this.btnSP4_dis.Click += new System.EventHandler(this.btnSP4_dis_Click);
            // 
            // cbSPname1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbSPname1, 2);
            this.cbSPname1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSPname1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSPname1.FormattingEnabled = true;
            this.cbSPname1.Items.AddRange(new object[] {
            "Port Name"});
            this.cbSPname1.Location = new System.Drawing.Point(3, 65);
            this.cbSPname1.Name = "cbSPname1";
            this.cbSPname1.Size = new System.Drawing.Size(78, 33);
            this.cbSPname1.TabIndex = 16;
            this.cbSPname1.DropDown += new System.EventHandler(this.cbSPname1_DropDown);
            // 
            // cbBau1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbBau1, 2);
            this.cbBau1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBau1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBau1.FormattingEnabled = true;
            this.cbBau1.Items.AddRange(new object[] {
            "BaudRate",
            "4800",
            "9600",
            "19200",
            "57600",
            "115200"});
            this.cbBau1.Location = new System.Drawing.Point(3, 96);
            this.cbBau1.Name = "cbBau1";
            this.cbBau1.Size = new System.Drawing.Size(78, 33);
            this.cbBau1.TabIndex = 17;
            this.cbBau1.DropDownClosed += new System.EventHandler(this.cbBau1_DropDownClosed);
            // 
            // cbSPname2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbSPname2, 2);
            this.cbSPname2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSPname2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSPname2.FormattingEnabled = true;
            this.cbSPname2.Items.AddRange(new object[] {
            "Port Name"});
            this.cbSPname2.Location = new System.Drawing.Point(423, 65);
            this.cbSPname2.Name = "cbSPname2";
            this.cbSPname2.Size = new System.Drawing.Size(78, 33);
            this.cbSPname2.TabIndex = 18;
            this.cbSPname2.DropDown += new System.EventHandler(this.cbSPname2_DropDown);
            // 
            // cbBau2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbBau2, 2);
            this.cbBau2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBau2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBau2.FormattingEnabled = true;
            this.cbBau2.Items.AddRange(new object[] {
            "BaudRate",
            "4800",
            "9600",
            "19200",
            "57600",
            "115200"});
            this.cbBau2.Location = new System.Drawing.Point(423, 96);
            this.cbBau2.Name = "cbBau2";
            this.cbBau2.Size = new System.Drawing.Size(78, 33);
            this.cbBau2.TabIndex = 19;
            this.cbBau2.DropDownClosed += new System.EventHandler(this.cbBau2_DropDownClosed);
            // 
            // cbSPname3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbSPname3, 2);
            this.cbSPname3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSPname3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSPname3.FormattingEnabled = true;
            this.cbSPname3.Items.AddRange(new object[] {
            "Port Name"});
            this.cbSPname3.Location = new System.Drawing.Point(3, 375);
            this.cbSPname3.Name = "cbSPname3";
            this.cbSPname3.Size = new System.Drawing.Size(78, 33);
            this.cbSPname3.TabIndex = 20;
            this.cbSPname3.DropDown += new System.EventHandler(this.cbSPname3_DropDown);
            // 
            // cbBau3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbBau3, 2);
            this.cbBau3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBau3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBau3.FormattingEnabled = true;
            this.cbBau3.Items.AddRange(new object[] {
            "BaudRate",
            "4800",
            "9600",
            "19200",
            "57600",
            "115200"});
            this.cbBau3.Location = new System.Drawing.Point(3, 406);
            this.cbBau3.Name = "cbBau3";
            this.cbBau3.Size = new System.Drawing.Size(78, 33);
            this.cbBau3.TabIndex = 21;
            this.cbBau3.DropDownClosed += new System.EventHandler(this.cbBau3_DropDownClosed);
            // 
            // cbSPname4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbSPname4, 2);
            this.cbSPname4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSPname4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSPname4.FormattingEnabled = true;
            this.cbSPname4.Items.AddRange(new object[] {
            "Port Name"});
            this.cbSPname4.Location = new System.Drawing.Point(423, 375);
            this.cbSPname4.Name = "cbSPname4";
            this.cbSPname4.Size = new System.Drawing.Size(78, 33);
            this.cbSPname4.TabIndex = 22;
            this.cbSPname4.DropDown += new System.EventHandler(this.cbSPname4_DropDown);
            // 
            // cbBau4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbBau4, 2);
            this.cbBau4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBau4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBau4.FormattingEnabled = true;
            this.cbBau4.Items.AddRange(new object[] {
            "BaudRate",
            "4800",
            "9600",
            "19200",
            "57600",
            "115200"});
            this.cbBau4.Location = new System.Drawing.Point(423, 406);
            this.cbBau4.Name = "cbBau4";
            this.cbBau4.Size = new System.Drawing.Size(78, 33);
            this.cbBau4.TabIndex = 23;
            this.cbBau4.DropDownClosed += new System.EventHandler(this.cbBau4_DropDownClosed);
            // 
            // lbSP1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.lbSP1, 8);
            this.lbSP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSP1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSP1.FormattingEnabled = true;
            this.lbSP1.ItemHeight = 23;
            this.lbSP1.Location = new System.Drawing.Point(87, 34);
            this.lbSP1.Name = "lbSP1";
            this.tableLayoutPanel2.SetRowSpan(this.lbSP1, 9);
            this.lbSP1.Size = new System.Drawing.Size(330, 273);
            this.lbSP1.TabIndex = 24;
            // 
            // btnSend1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSend1, 2);
            this.btnSend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend1.Location = new System.Drawing.Point(339, 3);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(78, 25);
            this.btnSend1.TabIndex = 28;
            this.btnSend1.Text = "Send";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // btnSend2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSend2, 2);
            this.btnSend2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend2.Location = new System.Drawing.Point(759, 3);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(90, 25);
            this.btnSend2.TabIndex = 29;
            this.btnSend2.Text = "Send";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // btnSend3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSend3, 2);
            this.btnSend3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend3.Location = new System.Drawing.Point(339, 313);
            this.btnSend3.Name = "btnSend3";
            this.btnSend3.Size = new System.Drawing.Size(78, 25);
            this.btnSend3.TabIndex = 30;
            this.btnSend3.Text = "Send";
            this.btnSend3.UseVisualStyleBackColor = true;
            this.btnSend3.Click += new System.EventHandler(this.btnSend3_Click);
            // 
            // btnSend4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnSend4, 2);
            this.btnSend4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend4.Location = new System.Drawing.Point(759, 313);
            this.btnSend4.Name = "btnSend4";
            this.btnSend4.Size = new System.Drawing.Size(90, 25);
            this.btnSend4.TabIndex = 31;
            this.btnSend4.Text = "Send";
            this.btnSend4.UseVisualStyleBackColor = true;
            this.btnSend4.Click += new System.EventHandler(this.btnSend4_Click);
            // 
            // textBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox1, 6);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(87, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 34);
            this.textBox1.TabIndex = 40;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox2, 6);
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(507, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 34);
            this.textBox2.TabIndex = 41;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // textBox3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox3, 6);
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(87, 313);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 34);
            this.textBox3.TabIndex = 42;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // textBox4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox4, 6);
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(507, 313);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(246, 34);
            this.textBox4.TabIndex = 43;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rbSP1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rbMT1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(78, 56);
            this.tableLayoutPanel3.TabIndex = 44;
            // 
            // rbSP1
            // 
            this.rbSP1.AutoSize = true;
            this.rbSP1.Checked = true;
            this.rbSP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSP1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbSP1.Location = new System.Drawing.Point(3, 3);
            this.rbSP1.Name = "rbSP1";
            this.rbSP1.Size = new System.Drawing.Size(72, 22);
            this.rbSP1.TabIndex = 0;
            this.rbSP1.TabStop = true;
            this.rbSP1.Text = "SerialPort";
            this.rbSP1.UseVisualStyleBackColor = true;
            this.rbSP1.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMT1
            // 
            this.rbMT1.AutoSize = true;
            this.rbMT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMT1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbMT1.Location = new System.Drawing.Point(3, 31);
            this.rbMT1.Name = "rbMT1";
            this.rbMT1.Size = new System.Drawing.Size(72, 22);
            this.rbMT1.TabIndex = 1;
            this.rbMT1.Text = "Motor";
            this.rbMT1.UseVisualStyleBackColor = true;
            this.rbMT1.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.rbSP2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbMT2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(423, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(78, 56);
            this.tableLayoutPanel4.TabIndex = 45;
            // 
            // rbSP2
            // 
            this.rbSP2.AutoSize = true;
            this.rbSP2.Checked = true;
            this.rbSP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSP2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbSP2.Location = new System.Drawing.Point(3, 3);
            this.rbSP2.Name = "rbSP2";
            this.rbSP2.Size = new System.Drawing.Size(72, 22);
            this.rbSP2.TabIndex = 0;
            this.rbSP2.TabStop = true;
            this.rbSP2.Text = "SerialPort";
            this.rbSP2.UseVisualStyleBackColor = true;
            this.rbSP2.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMT2
            // 
            this.rbMT2.AutoSize = true;
            this.rbMT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMT2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbMT2.Location = new System.Drawing.Point(3, 31);
            this.rbMT2.Name = "rbMT2";
            this.rbMT2.Size = new System.Drawing.Size(72, 22);
            this.rbMT2.TabIndex = 1;
            this.rbMT2.Text = "Motor";
            this.rbMT2.UseVisualStyleBackColor = true;
            this.rbMT2.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.rbSP3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.rbMT3, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 313);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(78, 56);
            this.tableLayoutPanel5.TabIndex = 46;
            // 
            // rbSP3
            // 
            this.rbSP3.AutoSize = true;
            this.rbSP3.Checked = true;
            this.rbSP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSP3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbSP3.Location = new System.Drawing.Point(3, 3);
            this.rbSP3.Name = "rbSP3";
            this.rbSP3.Size = new System.Drawing.Size(72, 22);
            this.rbSP3.TabIndex = 0;
            this.rbSP3.TabStop = true;
            this.rbSP3.Text = "SerialPort";
            this.rbSP3.UseVisualStyleBackColor = true;
            this.rbSP3.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMT3
            // 
            this.rbMT3.AutoSize = true;
            this.rbMT3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMT3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbMT3.Location = new System.Drawing.Point(3, 31);
            this.rbMT3.Name = "rbMT3";
            this.rbMT3.Size = new System.Drawing.Size(72, 22);
            this.rbMT3.TabIndex = 1;
            this.rbMT3.Text = "Motor";
            this.rbMT3.UseVisualStyleBackColor = true;
            this.rbMT3.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.rbSP4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rbMT4, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(423, 313);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(78, 56);
            this.tableLayoutPanel6.TabIndex = 47;
            // 
            // rbSP4
            // 
            this.rbSP4.AutoSize = true;
            this.rbSP4.Checked = true;
            this.rbSP4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSP4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbSP4.Location = new System.Drawing.Point(3, 3);
            this.rbSP4.Name = "rbSP4";
            this.rbSP4.Size = new System.Drawing.Size(72, 22);
            this.rbSP4.TabIndex = 0;
            this.rbSP4.TabStop = true;
            this.rbSP4.Text = "SerialPort";
            this.rbSP4.UseVisualStyleBackColor = true;
            this.rbSP4.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMT4
            // 
            this.rbMT4.AutoSize = true;
            this.rbMT4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMT4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbMT4.Location = new System.Drawing.Point(3, 31);
            this.rbMT4.Name = "rbMT4";
            this.rbMT4.Size = new System.Drawing.Size(72, 22);
            this.rbMT4.TabIndex = 1;
            this.rbMT4.Text = "Motor";
            this.rbMT4.UseVisualStyleBackColor = true;
            this.rbMT4.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // cbEOS1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbEOS1, 2);
            this.cbEOS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEOS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEOS1.FormattingEnabled = true;
            this.cbEOS1.Items.AddRange(new object[] {
            "None",
            "\\r",
            "\\n",
            "\\r\\n"});
            this.cbEOS1.Location = new System.Drawing.Point(3, 127);
            this.cbEOS1.Name = "cbEOS1";
            this.cbEOS1.Size = new System.Drawing.Size(78, 33);
            this.cbEOS1.TabIndex = 48;
            // 
            // cbEOS2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbEOS2, 2);
            this.cbEOS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEOS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEOS2.FormattingEnabled = true;
            this.cbEOS2.Items.AddRange(new object[] {
            "None",
            "\\r",
            "\\n",
            "\\r\\n"});
            this.cbEOS2.Location = new System.Drawing.Point(423, 127);
            this.cbEOS2.Name = "cbEOS2";
            this.cbEOS2.Size = new System.Drawing.Size(78, 33);
            this.cbEOS2.TabIndex = 49;
            // 
            // cbEOS3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbEOS3, 2);
            this.cbEOS3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEOS3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEOS3.FormattingEnabled = true;
            this.cbEOS3.Items.AddRange(new object[] {
            "None",
            "\\r",
            "\\n",
            "\\r\\n"});
            this.cbEOS3.Location = new System.Drawing.Point(3, 437);
            this.cbEOS3.Name = "cbEOS3";
            this.cbEOS3.Size = new System.Drawing.Size(78, 33);
            this.cbEOS3.TabIndex = 50;
            // 
            // cbEOS4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbEOS4, 2);
            this.cbEOS4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEOS4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEOS4.FormattingEnabled = true;
            this.cbEOS4.Items.AddRange(new object[] {
            "None",
            "\\r",
            "\\n",
            "\\r\\n"});
            this.cbEOS4.Location = new System.Drawing.Point(423, 437);
            this.cbEOS4.Name = "cbEOS4";
            this.cbEOS4.Size = new System.Drawing.Size(78, 33);
            this.cbEOS4.TabIndex = 51;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(858, 627);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(858, 627);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SerialPort Connect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort4;
        private System.IO.Ports.SerialPort serialPort3;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSP1_dis;
        private System.Windows.Forms.Button btnSP1;
        private System.Windows.Forms.Button btnSP2;
        private System.Windows.Forms.Button btnSP2_dis;
        private System.Windows.Forms.Button btnSP3;
        private System.Windows.Forms.Button btnSP3_dis;
        private System.Windows.Forms.Button btnSP4;
        private System.Windows.Forms.Button btnSP4_dis;
        private System.Windows.Forms.ComboBox cbSPname1;
        private System.Windows.Forms.ComboBox cbBau1;
        private System.Windows.Forms.ComboBox cbSPname2;
        private System.Windows.Forms.ComboBox cbBau2;
        private System.Windows.Forms.ComboBox cbSPname3;
        private System.Windows.Forms.ComboBox cbBau3;
        private System.Windows.Forms.ComboBox cbSPname4;
        private System.Windows.Forms.ComboBox cbBau4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbSP4;
        private System.Windows.Forms.ListBox lbSP3;
        private System.Windows.Forms.ListBox lbSP2;
        private System.Windows.Forms.ListBox lbSP1;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Button btnSend3;
        private System.Windows.Forms.Button btnSend4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton rbSP1;
        private System.Windows.Forms.RadioButton rbMT1;
        private System.Windows.Forms.RadioButton rbSP2;
        private System.Windows.Forms.RadioButton rbMT2;
        private System.Windows.Forms.RadioButton rbSP3;
        private System.Windows.Forms.RadioButton rbMT3;
        private System.Windows.Forms.RadioButton rbSP4;
        private System.Windows.Forms.RadioButton rbMT4;
        private System.Windows.Forms.ComboBox cbEOS1;
        private System.Windows.Forms.ComboBox cbEOS2;
        private System.Windows.Forms.ComboBox cbEOS3;
        private System.Windows.Forms.ComboBox cbEOS4;
    }
}

