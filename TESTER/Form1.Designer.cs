namespace TESTER
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label Label2;
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label Label5;
            System.Windows.Forms.Label OperatorBadgeID;
            System.Windows.Forms.Label TimeLabel;
            System.Windows.Forms.Label Label3;
            System.Windows.Forms.Label Total_Test_TimeLabel;
            System.Windows.Forms.Label Date_testLabel;
            System.Windows.Forms.Label Operator_testLabel;
            System.Windows.Forms.Label RWO_IdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.ComboBoxTimeOut = new System.Windows.Forms.ComboBox();
            this.ComboBoxCOMModTester = new System.Windows.Forms.ComboBox();
            this.ConnectDUT = new System.Windows.Forms.Button();
            this.RefreshBT = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBoxSN = new System.Windows.Forms.TextBox();
            this.CheckBoxDelay = new System.Windows.Forms.CheckBox();
            this.ComboBoxLot = new System.Windows.Forms.ComboBox();
            this.ComboBoxModel = new System.Windows.Forms.ComboBox();
            this.LabelTesting = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Total_Test_TimeTextBox = new System.Windows.Forms.TextBox();
            this.StopBT = new System.Windows.Forms.Button();
            this.Start_BT = new System.Windows.Forms.Button();
            this.TestingtimeStart1 = new System.Windows.Forms.TextBox();
            this.Date_testDate = new System.Windows.Forms.TextBox();
            this.ComboBoxOpName = new System.Windows.Forms.ComboBox();
            this.ComboBoxRWO_Id = new System.Windows.Forms.ComboBox();
            this.ResultTextBoxFCT = new System.Windows.Forms.TextBox();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.LabelWARNA = new System.Windows.Forms.Label();
            this.ComboBoxBadgeId = new System.Windows.Forms.ComboBox();
            this.ExcelDialog = new System.Windows.Forms.SaveFileDialog();
            this.Timer_PASS = new System.Windows.Forms.Timer(this.components);
            this.Timer_FAIL = new System.Windows.Forms.Timer(this.components);
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            Label4 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            OperatorBadgeID = new System.Windows.Forms.Label();
            TimeLabel = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Total_Test_TimeLabel = new System.Windows.Forms.Label();
            Date_testLabel = new System.Windows.Forms.Label();
            Operator_testLabel = new System.Windows.Forms.Label();
            RWO_IdLabel = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.Location = new System.Drawing.Point(16, 17);
            Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(141, 20);
            Label4.TabIndex = 487;
            Label4.Text = "Test Time Out :";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.Location = new System.Drawing.Point(455, 50);
            Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(91, 20);
            Label2.TabIndex = 550;
            Label2.Text = "Lot Size :";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.Location = new System.Drawing.Point(940, 100);
            Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(46, 20);
            Label1.TabIndex = 549;
            Label1.Text = "SN :";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.Location = new System.Drawing.Point(914, 65);
            Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(71, 20);
            Label5.TabIndex = 542;
            Label5.Text = "Model :";
            // 
            // OperatorBadgeID
            // 
            OperatorBadgeID.AutoSize = true;
            OperatorBadgeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OperatorBadgeID.Location = new System.Drawing.Point(14, 112);
            OperatorBadgeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OperatorBadgeID.Name = "OperatorBadgeID";
            OperatorBadgeID.Size = new System.Drawing.Size(179, 20);
            OperatorBadgeID.TabIndex = 531;
            OperatorBadgeID.Text = "Operator Badge ID :";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TimeLabel.Location = new System.Drawing.Point(386, 21);
            TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new System.Drawing.Size(109, 20);
            TimeLabel.TabIndex = 528;
            TimeLabel.Text = "Start Time :";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.Location = new System.Drawing.Point(830, 144);
            Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(145, 20);
            Label3.TabIndex = 539;
            Label3.Text = "TEST RESULT :";
            // 
            // Total_Test_TimeLabel
            // 
            Total_Test_TimeLabel.AutoSize = true;
            Total_Test_TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Total_Test_TimeLabel.Location = new System.Drawing.Point(1026, 9);
            Total_Test_TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Total_Test_TimeLabel.Name = "Total_Test_TimeLabel";
            Total_Test_TimeLabel.Size = new System.Drawing.Size(147, 20);
            Total_Test_TimeLabel.TabIndex = 537;
            Total_Test_TimeLabel.Text = "Total Test Time:";
            // 
            // Date_testLabel
            // 
            Date_testLabel.AutoSize = true;
            Date_testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Date_testLabel.Location = new System.Drawing.Point(96, 25);
            Date_testLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Date_testLabel.Name = "Date_testLabel";
            Date_testLabel.Size = new System.Drawing.Size(104, 20);
            Date_testLabel.TabIndex = 527;
            Date_testLabel.Text = "Date Test :";
            // 
            // Operator_testLabel
            // 
            Operator_testLabel.AutoSize = true;
            Operator_testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Operator_testLabel.Location = new System.Drawing.Point(44, 78);
            Operator_testLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Operator_testLabel.Name = "Operator_testLabel";
            Operator_testLabel.Size = new System.Drawing.Size(149, 20);
            Operator_testLabel.TabIndex = 526;
            Operator_testLabel.Text = "Operator Name :";
            // 
            // RWO_IdLabel
            // 
            RWO_IdLabel.AutoSize = true;
            RWO_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RWO_IdLabel.Location = new System.Drawing.Point(137, 49);
            RWO_IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            RWO_IdLabel.Name = "RWO_IdLabel";
            RWO_IdLabel.Size = new System.Drawing.Size(65, 20);
            RWO_IdLabel.TabIndex = 525;
            RWO_IdLabel.Text = "RWO :";
            // 
            // TextBox2
            // 
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(370, 142);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(35, 29);
            this.TextBox2.TabIndex = 555;
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.ComboBoxTimeOut);
            this.Panel1.Controls.Add(Label4);
            this.Panel1.Controls.Add(this.ComboBoxCOMModTester);
            this.Panel1.Controls.Add(this.ConnectDUT);
            this.Panel1.Controls.Add(this.RefreshBT);
            this.Panel1.Location = new System.Drawing.Point(907, 226);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(312, 134);
            this.Panel1.TabIndex = 553;
            // 
            // Button2
            // 
            this.Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2.BackgroundImage")));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button2.Location = new System.Drawing.Point(72, 96);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(37, 28);
            this.Button2.TabIndex = 557;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ComboBoxTimeOut
            // 
            this.ComboBoxTimeOut.FormattingEnabled = true;
            this.ComboBoxTimeOut.Location = new System.Drawing.Point(165, 17);
            this.ComboBoxTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxTimeOut.Name = "ComboBoxTimeOut";
            this.ComboBoxTimeOut.Size = new System.Drawing.Size(117, 24);
            this.ComboBoxTimeOut.TabIndex = 488;
            this.ComboBoxTimeOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxTimeOut_KeyDown);
            // 
            // ComboBoxCOMModTester
            // 
            this.ComboBoxCOMModTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCOMModTester.FormattingEnabled = true;
            this.ComboBoxCOMModTester.Location = new System.Drawing.Point(117, 96);
            this.ComboBoxCOMModTester.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxCOMModTester.Name = "ComboBoxCOMModTester";
            this.ComboBoxCOMModTester.Size = new System.Drawing.Size(109, 25);
            this.ComboBoxCOMModTester.TabIndex = 244;
            this.ComboBoxCOMModTester.Text = "Select COM";
            // 
            // ConnectDUT
            // 
            this.ConnectDUT.Enabled = false;
            this.ConnectDUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectDUT.Location = new System.Drawing.Point(51, 53);
            this.ConnectDUT.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectDUT.Name = "ConnectDUT";
            this.ConnectDUT.Size = new System.Drawing.Size(192, 34);
            this.ConnectDUT.TabIndex = 245;
            this.ConnectDUT.Text = "Connect DUT";
            this.ConnectDUT.UseVisualStyleBackColor = true;
            this.ConnectDUT.Click += new System.EventHandler(this.ConnectDUT_Click);
            // 
            // RefreshBT
            // 
            this.RefreshBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshBT.BackgroundImage")));
            this.RefreshBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshBT.Location = new System.Drawing.Point(-45, 56);
            this.RefreshBT.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBT.Name = "RefreshBT";
            this.RefreshBT.Size = new System.Drawing.Size(37, 28);
            this.RefreshBT.TabIndex = 246;
            this.RefreshBT.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(125, 147);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(77, 28);
            this.Button1.TabIndex = 547;
            this.Button1.Text = "CLEAR";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Visible = false;
            // 
            // TextBoxSN
            // 
            this.TextBoxSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSN.Location = new System.Drawing.Point(995, 97);
            this.TextBoxSN.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSN.Name = "TextBoxSN";
            this.TextBoxSN.Size = new System.Drawing.Size(235, 26);
            this.TextBoxSN.TabIndex = 543;
            this.TextBoxSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckBoxDelay
            // 
            this.CheckBoxDelay.AutoSize = true;
            this.CheckBoxDelay.Checked = true;
            this.CheckBoxDelay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxDelay.Location = new System.Drawing.Point(1210, 200);
            this.CheckBoxDelay.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxDelay.Name = "CheckBoxDelay";
            this.CheckBoxDelay.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxDelay.TabIndex = 552;
            this.CheckBoxDelay.UseVisualStyleBackColor = true;
            this.CheckBoxDelay.CheckedChanged += new System.EventHandler(this.CheckBoxDelay_CheckedChanged);
            // 
            // ComboBoxLot
            // 
            this.ComboBoxLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxLot.FormattingEnabled = true;
            this.ComboBoxLot.Location = new System.Drawing.Point(546, 46);
            this.ComboBoxLot.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxLot.Name = "ComboBoxLot";
            this.ComboBoxLot.Size = new System.Drawing.Size(112, 25);
            this.ComboBoxLot.TabIndex = 551;
            // 
            // ComboBoxModel
            // 
            this.ComboBoxModel.FormattingEnabled = true;
            this.ComboBoxModel.Items.AddRange(new object[] {
            "PWA-1506-00",
            "PWA-1519-00"});
            this.ComboBoxModel.Location = new System.Drawing.Point(995, 65);
            this.ComboBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxModel.Name = "ComboBoxModel";
            this.ComboBoxModel.Size = new System.Drawing.Size(235, 24);
            this.ComboBoxModel.TabIndex = 548;
            // 
            // LabelTesting
            // 
            this.LabelTesting.AutoSize = true;
            this.LabelTesting.Location = new System.Drawing.Point(284, 236);
            this.LabelTesting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTesting.Name = "LabelTesting";
            this.LabelTesting.Size = new System.Drawing.Size(0, 16);
            this.LabelTesting.TabIndex = 546;
            this.LabelTesting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(18, 152);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(95, 20);
            this.CheckBox1.TabIndex = 545;
            this.CheckBox1.Text = "LOG TEST";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.Visible = false;
            // 
            // Total_Test_TimeTextBox
            // 
            this.Total_Test_TimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Test_TimeTextBox.Location = new System.Drawing.Point(995, 34);
            this.Total_Test_TimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Total_Test_TimeTextBox.Name = "Total_Test_TimeTextBox";
            this.Total_Test_TimeTextBox.Size = new System.Drawing.Size(235, 26);
            this.Total_Test_TimeTextBox.TabIndex = 538;
            this.Total_Test_TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StopBT
            // 
            this.StopBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.StopBT.Location = new System.Drawing.Point(678, 78);
            this.StopBT.Margin = new System.Windows.Forms.Padding(4);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(212, 48);
            this.StopBT.TabIndex = 536;
            this.StopBT.Text = "STOP";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // Start_BT
            // 
            this.Start_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_BT.Location = new System.Drawing.Point(678, 23);
            this.Start_BT.Margin = new System.Windows.Forms.Padding(4);
            this.Start_BT.Name = "Start_BT";
            this.Start_BT.Size = new System.Drawing.Size(212, 48);
            this.Start_BT.TabIndex = 535;
            this.Start_BT.Text = "START TESTING";
            this.Start_BT.UseVisualStyleBackColor = true;
            this.Start_BT.Click += new System.EventHandler(this.Start_BT_Click);
            // 
            // TestingtimeStart1
            // 
            this.TestingtimeStart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestingtimeStart1.Location = new System.Drawing.Point(507, 18);
            this.TestingtimeStart1.Margin = new System.Windows.Forms.Padding(4);
            this.TestingtimeStart1.Name = "TestingtimeStart1";
            this.TestingtimeStart1.Size = new System.Drawing.Size(151, 23);
            this.TestingtimeStart1.TabIndex = 529;
            this.TestingtimeStart1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Date_testDate
            // 
            this.Date_testDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_testDate.Location = new System.Drawing.Point(214, 18);
            this.Date_testDate.Margin = new System.Windows.Forms.Padding(4);
            this.Date_testDate.Name = "Date_testDate";
            this.Date_testDate.Size = new System.Drawing.Size(161, 23);
            this.Date_testDate.TabIndex = 530;
            this.Date_testDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboBoxOpName
            // 
            this.ComboBoxOpName.Enabled = false;
            this.ComboBoxOpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOpName.FormattingEnabled = true;
            this.ComboBoxOpName.Location = new System.Drawing.Point(214, 76);
            this.ComboBoxOpName.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxOpName.Name = "ComboBoxOpName";
            this.ComboBoxOpName.Size = new System.Drawing.Size(444, 25);
            this.ComboBoxOpName.TabIndex = 533;
            // 
            // ComboBoxRWO_Id
            // 
            this.ComboBoxRWO_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRWO_Id.FormattingEnabled = true;
            this.ComboBoxRWO_Id.Location = new System.Drawing.Point(214, 46);
            this.ComboBoxRWO_Id.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxRWO_Id.Name = "ComboBoxRWO_Id";
            this.ComboBoxRWO_Id.Size = new System.Drawing.Size(224, 25);
            this.ComboBoxRWO_Id.TabIndex = 532;
            // 
            // ResultTextBoxFCT
            // 
            this.ResultTextBoxFCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBoxFCT.Location = new System.Drawing.Point(996, 139);
            this.ResultTextBoxFCT.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTextBoxFCT.Name = "ResultTextBoxFCT";
            this.ResultTextBoxFCT.Size = new System.Drawing.Size(234, 29);
            this.ResultTextBoxFCT.TabIndex = 540;
            this.ResultTextBoxFCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SerialPort1
            // 
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(327, 142);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(35, 29);
            this.TextBox1.TabIndex = 554;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelWARNA
            // 
            this.LabelWARNA.AutoSize = true;
            this.LabelWARNA.Location = new System.Drawing.Point(1407, 130);
            this.LabelWARNA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWARNA.Name = "LabelWARNA";
            this.LabelWARNA.Size = new System.Drawing.Size(0, 16);
            this.LabelWARNA.TabIndex = 544;
            this.LabelWARNA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxBadgeId
            // 
            this.ComboBoxBadgeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBadgeId.FormattingEnabled = true;
            this.ComboBoxBadgeId.Location = new System.Drawing.Point(214, 107);
            this.ComboBoxBadgeId.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxBadgeId.Name = "ComboBoxBadgeId";
            this.ComboBoxBadgeId.Size = new System.Drawing.Size(444, 25);
            this.ComboBoxBadgeId.TabIndex = 534;
            this.ComboBoxBadgeId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxBadgeID_KeyDown);
            // 
            // Timer_PASS
            // 
            this.Timer_PASS.Tick += new System.EventHandler(this.Timer_PASS_Tick);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RichTextBox1.Location = new System.Drawing.Point(13, 183);
            this.RichTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(1235, 371);
            this.RichTextBox1.TabIndex = 541;
            this.RichTextBox1.Text = "";
            this.RichTextBox1.WordWrap = false;
            // 
            // RichTextBox2
            // 
            this.RichTextBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RichTextBox2.Location = new System.Drawing.Point(48, 226);
            this.RichTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.Size = new System.Drawing.Size(1153, 148);
            this.RichTextBox2.TabIndex = 556;
            this.RichTextBox2.Text = "";
            this.RichTextBox2.WordWrap = false;
            // 
            // TextBox3
            // 
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.Location = new System.Drawing.Point(413, 142);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(35, 29);
            this.TextBox3.TabIndex = 557;
            this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox4
            // 
            this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox4.Location = new System.Drawing.Point(456, 142);
            this.TextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(35, 29);
            this.TextBox4.TabIndex = 558;
            this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox5
            // 
            this.TextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox5.Location = new System.Drawing.Point(503, 142);
            this.TextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(35, 29);
            this.TextBox5.TabIndex = 559;
            this.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 567);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBoxSN);
            this.Controls.Add(this.CheckBoxDelay);
            this.Controls.Add(this.ComboBoxLot);
            this.Controls.Add(this.ComboBoxModel);
            this.Controls.Add(this.LabelTesting);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Total_Test_TimeTextBox);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.Start_BT);
            this.Controls.Add(this.TestingtimeStart1);
            this.Controls.Add(this.Date_testDate);
            this.Controls.Add(this.ComboBoxOpName);
            this.Controls.Add(this.ComboBoxRWO_Id);
            this.Controls.Add(this.ResultTextBoxFCT);
            this.Controls.Add(Label2);
            this.Controls.Add(Label1);
            this.Controls.Add(Label5);
            this.Controls.Add(OperatorBadgeID);
            this.Controls.Add(TimeLabel);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.LabelWARNA);
            this.Controls.Add(Label3);
            this.Controls.Add(Total_Test_TimeLabel);
            this.Controls.Add(this.ComboBoxBadgeId);
            this.Controls.Add(Date_testLabel);
            this.Controls.Add(Operator_testLabel);
            this.Controls.Add(RWO_IdLabel);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.RichTextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "[C#] TESTER VISPERO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ComboBox ComboBoxTimeOut;
        internal System.Windows.Forms.ComboBox ComboBoxCOMModTester;
        internal System.Windows.Forms.Button ConnectDUT;
        internal System.Windows.Forms.Button RefreshBT;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBoxSN;
        internal System.Windows.Forms.CheckBox CheckBoxDelay;
        internal System.Windows.Forms.ComboBox ComboBoxLot;
        internal System.Windows.Forms.ComboBox ComboBoxModel;
        internal System.Windows.Forms.Label LabelTesting;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.TextBox Total_Test_TimeTextBox;
        internal System.Windows.Forms.Button StopBT;
        internal System.Windows.Forms.Button Start_BT;
        internal System.Windows.Forms.TextBox TestingtimeStart1;
        internal System.Windows.Forms.TextBox Date_testDate;
        internal System.Windows.Forms.ComboBox ComboBoxOpName;
        internal System.Windows.Forms.ComboBox ComboBoxRWO_Id;
        internal System.Windows.Forms.TextBox ResultTextBoxFCT;
        internal System.IO.Ports.SerialPort SerialPort1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label LabelWARNA;
        internal System.Windows.Forms.ComboBox ComboBoxBadgeId;
        internal System.Windows.Forms.SaveFileDialog ExcelDialog;
        internal System.Windows.Forms.Timer Timer_PASS;
        internal System.Windows.Forms.Timer Timer_FAIL;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.RichTextBox RichTextBox2;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.TextBox TextBox5;
    }
}

