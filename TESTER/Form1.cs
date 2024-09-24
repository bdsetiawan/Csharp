using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace TESTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // ------------------VARIABLE---------------------------

        //Array myPort;

        DateTime TestingtimeEnd;
        DateTime TestingtimeStart,TestingtimeStart_awal, TestingtimeStart_fct;
        string result_sw1, result_sw2, result_sw3, result_sw4_right, result_sw4_left;
        //string filepath1, filepath2, filepath3, filepath4;


        // -----------------------------------------------------

        public void Delay(double dblsecs)  //ok
        {
            double onesec = 1.0 / (1440.0 * 60.0);
            DateTime dblWaitTil;
            DateTime.Now.AddSeconds(onesec);
            dblWaitTil = DateTime.Now.AddSeconds(onesec).AddSeconds(dblsecs);
            while (DateTime.Now < dblWaitTil)  //seperti do until --loop tapi dibalik 
            {
                Application.DoEvents();
            }
        }


        public delegate void SetTextCallback(string text); 

        private void Form1_Load(object sender, EventArgs e)
        {
            Date_testDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            Total_Test_TimeTextBox.Text = "00:00:00";

            CheckBoxDelay.Checked = false;

            string filepath1 = @"C:\TESTER\Data\Operator_Name.txt";
            ComboBoxOpName.Items.AddRange(File.ReadAllLines(filepath1));
            ComboBoxOpName.Text = ComboBoxOpName.Items[0].ToString();

            string filepath2 = @"C:\TESTER\Data\BadgeID.txt";
            ComboBoxBadgeId.Items.AddRange(File.ReadAllLines(filepath2));
            ComboBoxBadgeId.Text = ComboBoxBadgeId.Items[0].ToString();

            string filepath3 = @"C:\TESTER\Data\TestTimeOut.txt";
            ComboBoxTimeOut.Items.AddRange(File.ReadAllLines(filepath3));
            ComboBoxTimeOut.Text = ComboBoxTimeOut.Items[0].ToString();
        }



        private void Timer_PASS_Tick(object sender, EventArgs e)

        //public void Cek_PASS()
        {
            if (RichTextBox2.Text.Contains("#X0#X1"))
            {
                TextBox1.BackColor = Color.Green;
                //Delay(0.5);
                RichTextBox2.Clear();
                //TextBox1.BackColor = Color.White;
            }



            //-------------------------------------------------

            if (RichTextBox2.Text.Contains("#F0#F1"))
            {
                TextBox2.BackColor = Color.Green;
                //Delay(0.5);
                RichTextBox2.Clear();
                //TextBox1.BackColor = Color.White;
            }


            //-------------------------------------------------

            if (RichTextBox2.Text.Contains("#M0#M1"))
            {
                TextBox3.BackColor = Color.Green;
                //Delay(0.5);
                RichTextBox2.Clear();
                //TextBox1.BackColor = Color.White;
            }



            //-------------------------------------------------

            if (RichTextBox2.Text.Contains("#P#P#P"))
            {
                TextBox4.BackColor = Color.Green;
                //Delay(0.5);
                RichTextBox2.Clear();
                //TextBox1.BackColor = Color.White;
            }

            if (RichTextBox2.Text.Contains("#N#N#N"))
            {
                TextBox5.BackColor = Color.Green;
                //Delay(0.5);
                RichTextBox2.Clear();
                //TextBox2.BackColor = Color.White;
            }


        }

        //-------------------------------------------------
        public void Cek_PASS()
        { 

            if (RichTextBox1.Text.Contains("#X0#X1"))
            {
                result_sw1 = "PASS";
            }

            if (RichTextBox1.Text.Contains("#F0#F1"))
            {
                result_sw2 = "PASS";
            }

            if (RichTextBox1.Text.Contains("#M0#M1"))
            {
                result_sw3 = "PASS";
            }

            if (RichTextBox1.Text.Contains("#P#P#P"))
            {
                result_sw4_right = "PASS";
            }

            if (RichTextBox1.Text.Contains("#N#N#N"))
            {
                result_sw4_left = "PASS";
            }
        }

        //private async void Delay(int milliseconds)  ' cek tentang ini
        //{
        //   await Task.Delay(milliseconds);
        //}
        public void Cek_fail()
        {
            if (!RichTextBox1.Text.Contains("#X0#X1"))
            {
                result_sw1 = "FAIL";
            }

            if (!RichTextBox1.Text.Contains("#F0#F1"))
            {
                result_sw2 = "FAIL";
            }

            if (!RichTextBox1.Text.Contains("#M0#M1"))
            {
                result_sw3 = "FAIL";
            }

            if (!RichTextBox1.Text.Contains("#P#P#P"))
            {
                result_sw4_right = "FAIL";
            }

            if (!RichTextBox1.Text.Contains("#N#N#N"))
            {
                result_sw4_left = "FAIL";
            }
        }



        private void CheckBoxDelay_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxDelay.Checked)
            {
                //if (CheckBoxShowCOM.CheckedChanged() == true)
                //{
                //    PanelCOM.Show();
                //    this.Size = new System.Drawing.Size(1197, 361);
                //}
                Panel1.Show();
            }
            else
            {
                //PanelCOM.Hide();
                //this.Size = new System.Drawing.Size(1012, 245);
                //this.Size = new System.Drawing.Size(1197, 190);
                Panel1.Hide();
            }
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            DUTDisconnect();
            //Timer1.Enabled = false;
            //Timer2.Enabled = false;
            Timer_PASS.Enabled = false;
            Timer_FAIL.Enabled = false;
            stop_process();
            clean_log();
        }

       


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                //if (CheckBoxShowCOM.CheckedChanged() == true)
                //{
                //    PanelCOM.Show();
                //}
                this.Size = new System.Drawing.Size(1197, 361);
                LabelTesting.Hide();
            }
            else
            {
                //PanelCOM.Hide();
                //this.Size = new System.Drawing.Size(1012, 245);
                this.Size = new System.Drawing.Size(1197, 190);
                LabelTesting.Show();
            }
        }

        private string GetValueOpName(int row, int col)
        {
            //https://stackoverflow.com/questions/62584487/reading-a-specific-value-in-a-cell-in-a-csv-file-in-vb-net
            string csvPath = "C:/TESTER/Data/OperatorName.csv";
            string result = string.Empty;
            string[] lines = File.ReadAllLines(csvPath);
            if (row < lines.Length)
            {
                string[] cols = lines[row].Split(',');
                if (col < cols.Length)
                {
                    result = cols[col];
                }
            }
            return result;
        }

        private void ComboBoxBadgeID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //private void ComboBoxBadgeID_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (StreamWriter writer4 = new StreamWriter("C:\\TESTER\\Data\\BadgeID.txt"))
                {
                    ComboBoxBadgeId.Text = ComboBoxBadgeId.Text.ToUpper();
                    writer4.WriteLine(ComboBoxBadgeId.Text);
                }
                //Form50000792_01.OperatorBadgeIDTextBox.Text = ComboBoxBadgeID.Text;

                for (int row_ = 1; row_ <= File.ReadAllLines("C:\\TESTER\\Data\\OperatorName.csv").Length; row_++)
                {
                    if (GetValueOpName(row_, 0) == ComboBoxBadgeId.Text) //untuk combo gunakan text bukan SelectedItem 
                    {
                        //MsgBox("found it");
                        //Build_Num_val_ref = GetValue(row_, 1);
                        ComboBoxOpName.Text = GetValueOpName(row_, 1);

                        using (StreamWriter writer3 = new StreamWriter("C:\\TESTER\\Data\\Operator_Name.txt"))
                        {
                            ComboBoxOpName.Text = ComboBoxOpName.Text.ToUpper();
                            writer3.WriteLine(ComboBoxOpName.Text);
                        }
                        //Form50000792_01.Operator_testTextBox.Text = ComboBoxOpName.Text;
                    }
                }
            }
        }

        private void clean_log()
        {
            result_sw1 = "";
            result_sw2 = "";
            result_sw3 = "";
            result_sw4_right = "";
            result_sw4_left = "";

            TextBox1.BackColor = Color.White;
            TextBox2.BackColor = Color.White;
            TextBox3.BackColor = Color.White;
            TextBox4.BackColor = Color.White;
            TextBox5.BackColor = Color.White;

        }

        private void stop_process()
        {
            Total_Test_TimeTextBox.Text = "00:00:00";
            Start_BT.Enabled = true;
            StopBT.Enabled = true;
            Start_BT.BackColor = Color.Orange;
            ResultTextBoxFCT.Clear();
            ResultTextBoxFCT.BackColor = Color.White;

            RichTextBox1.Clear();
            RichTextBox2.Clear();
            TextBoxSN.Clear();
            //DataGridView1.ClearSelection();
        }



        private void Start_BT_Click(object sender, EventArgs e)
        {


            TestingtimeStart1.Text = DateTime.Now.ToString("HH:mm:ss");
            TestingtimeStart_awal = DateTime.Parse(TestingtimeStart1.Text);
            Date_testDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");


            if (string.IsNullOrEmpty(ComboBoxModel.Text) || string.IsNullOrEmpty(ComboBoxRWO_Id.Text) ||
                string.IsNullOrEmpty(ComboBoxLot.Text) || string.IsNullOrEmpty(ComboBoxOpName.Text) ||
                string.IsNullOrEmpty(ComboBoxBadgeId.Text) || ComboBoxCOMModTester.Text == "Select COM")
            {
                MessageBox.Show("Masukan data dengan BENAR dan LENGKAP");
                stop_process();
                return;
            }

            clean_log();
            stop_process();

            Timer_PASS.Enabled = false;

            Start_BT.BackColor = Color.Orange;
            StopBT.BackColor = Color.White;
            RichTextBox1.Clear();
            RichTextBox2.Clear();

            if (TextBoxSN.Text.Length != 10)
            {
                do
                {
                    TextBoxSN.Text = "";
                    TextBoxSN.Text = Interaction.InputBox("Scan Serial Number ID (10 digit)", "TESTING :", "", 500, 450);
                    if (string.IsNullOrEmpty(TextBoxSN.Text))
                    {
                        stop_process();
                        return;
                    }
                } while (TextBoxSN.Text.Length != 10);
            }

            TestingtimeStart1.Text = DateTime.Now.ToString("HH:mm:ss");
            TestingtimeStart_fct = DateTime.Parse(TestingtimeStart1.Text);
            TestingtimeStart = DateTime.Parse(TestingtimeStart1.Text); // Used for datagrid timing
            Date_testDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");

            DUTConnect();
            Timer_PASS.Start();
            Timer_PASS.Enabled = true;
            //Delay(2);
            

            Delay(Convert.ToDouble(ComboBoxTimeOut.Text));
            //Delay(Int32.Parse(ComboBoxTimeOut.Text));
            //Delay(10);

            DUTDisconnect();


            Timer_PASS.Stop();
            Timer_PASS.Enabled = false;

            

            Cek_PASS();

            Cek_fail();



            if (result_sw1 == "PASS" && result_sw2 == "PASS" && result_sw3 == "PASS" &&
                result_sw4_right == "PASS" && result_sw4_left == "PASS")
            {
                ResultTextBoxFCT.Text = "PASS";
                ResultTextBoxFCT.BackColor = Color.Green;
            }
            else
            {
                ResultTextBoxFCT.Text = "FAIL";
                ResultTextBoxFCT.BackColor = Color.IndianRed;
            }

            log_finish_test();


        }





        private void Button2_Click(object sender, EventArgs e)
        {
            ComboBoxCOMModTester.Items.Clear();
            string[] myPort = SerialPort.GetPortNames();
            foreach (string port in myPort)
            {
                ComboBoxCOMModTester.Items.Add(port);
            }
        }





        private void log_finish_test()
        {
            //Timer1.Enabled = false;
            Timer_PASS.Enabled = false;
            Timer_FAIL.Enabled = false;

            Start_BT.BackColor = Color.White;
            StopBT.BackColor = Color.Orange;

            TestingtimeEnd = DateTime.Now;
            Total_Test_TimeTextBox.Text = (TestingtimeEnd - TestingtimeStart_fct).ToString(@"hh\:mm\:ss");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            //sb.AppendLine("==========================SUMMARY TEST====================");
            sb.AppendLine($"Model                     :  {ComboBoxModel.Text}");
            sb.AppendLine($"RWO Number                :  {ComboBoxRWO_Id.Text}");
            sb.AppendLine($"Lot Size                  :  {ComboBoxLot.Text}");
            sb.AppendLine($"Serial Number             :  {TextBoxSN.Text}");
            sb.AppendLine($"Operator Name             :  {ComboBoxOpName.Text.ToUpper()}");
            sb.AppendLine($"Operator Badge ID         :  {ComboBoxBadgeId.Text}");
            sb.AppendLine($"Date Test                 :  {DateTime.Now.ToString("dd-MMM-yyyy")}");
            sb.AppendLine($"Testing Time Start        :  {TestingtimeStart1.Text}");
            sb.AppendLine($"Testing Time End          :  {TestingtimeEnd.ToString("HH:mm:ss")}");
            sb.AppendLine($"Testing Time Duration     :  {Total_Test_TimeTextBox.Text}");
            sb.AppendLine($"Result FCT                :  {ResultTextBoxFCT.Text}");
            //sb.AppendLine("==========================================================");
            sb.AppendLine();
            //sb.AppendLine("============================TEST==========================");
            sb.AppendLine();
            sb.AppendLine($"SWITCH #1 (SW1)                                  |{result_sw1}|");
            sb.AppendLine("----------------------------------------------------------");
            sb.AppendLine($"SWITCH #2 (SW2)                                  |{result_sw2}|");
            sb.AppendLine("----------------------------------------------------------");
            sb.AppendLine($"SWITCH #3 (SW3)                                  |{result_sw3}|");
            sb.AppendLine("----------------------------------------------------------");
            sb.AppendLine($"SWITCH #4 (SW4) turn right                       |{result_sw4_right}|");
            sb.AppendLine("----------------------------------------------------------");
            sb.AppendLine($"SWITCH #4 (SW4) turn left                        |{result_sw4_left}|");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("-------------------------ORIGINAL-------------------------");
            sb.AppendLine();
            sb.AppendLine(RichTextBox1.Text);
            sb.AppendLine();
            //sb.AppendLine("===========================END============================");

            RichTextBox1.Text = sb.ToString();

            string sPath1 = Path.Combine(@"C:\TESTER\Log Testing\", ComboBoxRWO_Id.Text);
            string sPath2 = Path.Combine(@"C:\TESTER\Log Testing\", ComboBoxRWO_Id.Text, ComboBoxModel.Text);
            string sPath3 = Path.Combine(@"C:\TESTER\Log Testing\", ComboBoxRWO_Id.Text, ComboBoxModel.Text, "PASS");
            string sPath4 = Path.Combine(@"C:\TESTER\Log Testing\", ComboBoxRWO_Id.Text, ComboBoxModel.Text, "FAIL");

            if (ResultTextBoxFCT.Text == "PASS")
            {
                Directory.CreateDirectory(sPath3);
                ExcelDialog.FileName = Path.Combine(@"C:\TESTER\Log Testing\", ComboBoxRWO_Id.Text, ComboBoxModel.Text, "PASS",
                    $"{ComboBoxModel.Text}_{TextBoxSN.Text}_{DateTime.Now.ToString("ddMMyyyy")}_{TestingtimeStart.ToString("HHmmss")}_{ResultTextBoxFCT.Text}.txt");

                RichTextBox1.SaveFile(ExcelDialog.FileName, RichTextBoxStreamType.PlainText);
                RichTextBox1.SaveFile(ExcelDialog.FileName, RichTextBoxStreamType.PlainText);
            }

            if (ResultTextBoxFCT.Text == "FAIL")
            {
                Directory.CreateDirectory(sPath4);
                ExcelDialog.FileName = Path.Combine(@"C:\TESTER\Log Testing\", ComboBoxRWO_Id.Text, ComboBoxModel.Text, "FAIL",
                    $"{ComboBoxModel.Text}_{TextBoxSN.Text}_{DateTime.Now.ToString("ddMMyyyy")}_{TestingtimeStart.ToString("HHmmss")}_{ResultTextBoxFCT.Text}.txt");

                RichTextBox1.SaveFile(ExcelDialog.FileName, RichTextBoxStreamType.PlainText);
                RichTextBox1.SaveFile(ExcelDialog.FileName, RichTextBoxStreamType.PlainText);
            }

            MessageBox.Show("**** TESTING SELESAI ****");



        }



        private void ConnectDUT_Click(object sender, EventArgs e)
        {
            if (ConnectDUT.Text == "Connect DUT")
            {
                DUTConnect();
            }
            else if (ConnectDUT.Text == "Disconnect DUT")
            {
                DUTDisconnect();
            }
        }

        private void DUTConnect()
        {
            if (string.IsNullOrEmpty(ComboBoxCOMModTester.Text) ||
                ComboBoxCOMModTester.Text == "Select COM")
            {
                MessageBox.Show("Check COM or Baud Rate, then click Connect", "TESTER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectDUT.BackColor = Color.IndianRed;
                ComboBoxCOMModTester.Select();
                return; //out from function, will not continue to below
            }

            try
            {
                DUTDisconnect();

                //int BR = 9600;

                SerialPort1.PortName = ComboBoxCOMModTester.Text;
                SerialPort1.BaudRate = 9600;
                SerialPort1.Open();
                SerialPort1.Parity = Parity.None;
                SerialPort1.StopBits = StopBits.One;
                SerialPort1.DataBits = 8;
                SerialPort1.Handshake = Handshake.None;
                SerialPort1.RtsEnable = true;
                SerialPort1.DiscardOutBuffer();
                SerialPort1.DiscardInBuffer();
                ConnectDUT.Text = "Disconnect DUT";

                if (SerialPort1.IsOpen)
                {
                    ConnectDUT.BackColor = Color.LightGreen;
                }

                using (StreamWriter writer5 = new StreamWriter(@"C:\TESTER\Data\COM_ModTester.txt"))
                {
                    writer5.WriteLine(ComboBoxCOMModTester.Text);
                }
            }
            catch (Exception ex)
            {
                ConnectDUT.Text = "Connect DUT";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxTimeOut_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)

        //private void ComboBoxTimeOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (StreamWriter writer1 = new StreamWriter(@"C:\TESTER\Data\TestTimeOut.txt"))
                {
                    writer1.WriteLine(ComboBoxTimeOut.Text);
                }
                ComboBoxTimeOut.Select();
            }
        }



        private void DUTDisconnect()
        {
            if (SerialPort1.IsOpen)
            {
                ConnectDUT.Text = "Connect DUT";
                Timer_PASS.Stop();
                Timer_PASS.Enabled = false;
                Timer_FAIL.Stop();
                Timer_FAIL.Enabled = false;

                SerialPort1.Close();

                ConnectDUT.Enabled = true;
                ConnectDUT.BackColor = Color.White;
            }
        }









        //-----------------------------------------------------




        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceivedText(SerialPort1.ReadExisting());
            //ReceivedText(SerialPort1.ReadLine());
            if (e.ToString().Contains("SerialDataReceived"))
            {
                // n = n + 1
                // RichTextBoxTemp.Text += n + Environment.NewLine;
                // RichTextBoxTemp.Clear();
            }
        }


        //----------------------function read serial/incoming data--------------------------
        private void ReceivedText(string text) // function to input from ReadExisting
        {
            // RichTextBox1.AppendText(text + Environment.NewLine); // append text
            // RichTextBoxTemp.AppendText(text + Environment.NewLine); // append

            if (RichTextBox1.InvokeRequired)
            {
                SetTextCallback x = new SetTextCallback(ReceivedText);
                RichTextBox1.Invoke(x, new object[] { text });
            }
            else
            {
                RichTextBox1.AppendText(text); // append text
                //replace_symbol();
                RichTextBox2.AppendText(text); // append
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read the data from the serial port
            string dataReceived = SerialPort1.ReadExisting();
            //string dataReceived = SerialPort1.ReadLine();

            RichTextBox1.AppendText(dataReceived);
            RichTextBox2.AppendText(dataReceived);
        }





        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Apakah yakin menutup aplikasi ini?", "Close TESTING #1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    conn.Close();

            //    Process[] pProcess1 = Process.GetProcessesByName(LabelModBuildNumber.Text + "_TESTING_1"); //jgn pakai exe, langsung kill form

            //    foreach (Process p in pProcess1)
            //    {
            //        p.Kill();
            //        Process.Start("parsing_v2");
            //        p.Start();
            //    }

            //    Process[] pProcess2 = Process.GetProcessesByName("Form_" + LabelModBuildNumber.Text + "_TESTING_1"); //jgn pakai exe, langsung kill form

            //    foreach (Process p in pProcess2)
            //    {
            //        p.Kill();
            //        Process.Start("parsing_v2");
            //        p.Start();
            //    }

            Process[] pProcess3 = Process.GetProcessesByName("TESTER"); //jgn pakai exe, langsung kill form

            foreach (Process p in pProcess3)
            {
                p.Kill();
                //Process.Start("parsing_v2");
                //p.Start();
            }

            Environment.Exit(0);
            //Application.Exit();
            Close();
            //Environment.Exit(0);
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }
















        //-------------------------END--------------------------------------

    }
}
