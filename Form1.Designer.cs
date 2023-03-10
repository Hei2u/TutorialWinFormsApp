namespace TutorialWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.comboMeasureType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlarmH = new System.Windows.Forms.TextBox();
            this.txtAlarmL = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtURV = new System.Windows.Forms.TextBox();
            this.txtLRV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnReg = new System.Windows.Forms.Button();
            this.txtRegistered = new System.Windows.Forms.TextBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new System.Windows.Forms.RadioButton();
            this.BtnSaveChanges = new System.Windows.Forms.RadioButton();
            this.BtnRegisterNew = new System.Windows.Forms.RadioButton();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.listOptions = new System.Windows.Forms.ListBox();
            this.comboSignalType = new System.Windows.Forms.ComboBox();
            this.dTpRegDate = new System.Windows.Forms.DateTimePicker();
            this.checkRegistered = new System.Windows.Forms.CheckBox();
            this.MtxtSerialNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtSensorName = new System.Windows.Forms.TextBox();
            this.LblComment = new System.Windows.Forms.Label();
            this.LblOptions = new System.Windows.Forms.Label();
            this.LblSignalType = new System.Windows.Forms.Label();
            this.LblRegDate = new System.Windows.Forms.Label();
            this.LblRegistered = new System.Windows.Forms.Label();
            this.LblSerialNumber = new System.Windows.Forms.Label();
            this.LblSensorName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtComReceived = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnComConnect = new System.Windows.Forms.Button();
            this.txtBaudRate = new System.Windows.Forms.ComboBox();
            this.txtComPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnReadscaled = new System.Windows.Forms.Button();
            this.btnReadstate = new System.Windows.Forms.Button();
            this.btnWriteconfig = new System.Windows.Forms.Button();
            this.btnReadconfig = new System.Windows.Forms.Button();
            this.txtCommunication = new System.Windows.Forms.TextBox();
            this.checkStayConnected = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxServer = new System.Windows.Forms.ListBox();
            this.tabSignal = new System.Windows.Forms.TabPage();
            this.btnStopMonitoring = new System.Windows.Forms.Button();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timeReadScaled = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.sensorData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabSignal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sensorData
            // 
            this.sensorData.Controls.Add(this.tabPage1);
            this.sensorData.Controls.Add(this.tabPage2);
            this.sensorData.Controls.Add(this.tabPage3);
            this.sensorData.Controls.Add(this.tabSignal);
            this.sensorData.Location = new System.Drawing.Point(2, 29);
            this.sensorData.Name = "sensorData";
            this.sensorData.SelectedIndex = 0;
            this.sensorData.Size = new System.Drawing.Size(944, 385);
            this.sensorData.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtSummary);
            this.tabPage1.Controls.Add(this.comboMeasureType);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.group2);
            this.tabPage1.Controls.Add(this.BtnReg);
            this.tabPage1.Controls.Add(this.txtRegistered);
            this.tabPage1.Controls.Add(this.group1);
            this.tabPage1.Controls.Add(this.txtComment);
            this.tabPage1.Controls.Add(this.listOptions);
            this.tabPage1.Controls.Add(this.comboSignalType);
            this.tabPage1.Controls.Add(this.dTpRegDate);
            this.tabPage1.Controls.Add(this.checkRegistered);
            this.tabPage1.Controls.Add(this.MtxtSerialNumber);
            this.tabPage1.Controls.Add(this.txtSensorName);
            this.tabPage1.Controls.Add(this.LblComment);
            this.tabPage1.Controls.Add(this.LblOptions);
            this.tabPage1.Controls.Add(this.LblSignalType);
            this.tabPage1.Controls.Add(this.LblRegDate);
            this.tabPage1.Controls.Add(this.LblRegistered);
            this.tabPage1.Controls.Add(this.LblSerialNumber);
            this.tabPage1.Controls.Add(this.LblSensorName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sensor Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.MouseHover += new System.EventHandler(this.tabPage1_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Summary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(716, 17);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(125, 270);
            this.txtSummary.TabIndex = 18;
            // 
            // comboMeasureType
            // 
            this.comboMeasureType.FormattingEnabled = true;
            this.comboMeasureType.Location = new System.Drawing.Point(154, 169);
            this.comboMeasureType.Name = "comboMeasureType";
            this.comboMeasureType.Size = new System.Drawing.Size(151, 28);
            this.comboMeasureType.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Measure Type";
            // 
            // group2
            // 
            this.group2.Controls.Add(this.label8);
            this.group2.Controls.Add(this.label7);
            this.group2.Controls.Add(this.txtAlarmH);
            this.group2.Controls.Add(this.txtAlarmL);
            this.group2.Controls.Add(this.txtUnit);
            this.group2.Controls.Add(this.txtURV);
            this.group2.Controls.Add(this.txtLRV);
            this.group2.Controls.Add(this.label4);
            this.group2.Controls.Add(this.label3);
            this.group2.Controls.Add(this.label2);
            this.group2.Location = new System.Drawing.Point(404, 14);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(157, 207);
            this.group2.TabIndex = 14;
            this.group2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "AlarmH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "AlarmL";
            // 
            // txtAlarmH
            // 
            this.txtAlarmH.Location = new System.Drawing.Point(59, 166);
            this.txtAlarmH.Name = "txtAlarmH";
            this.txtAlarmH.Size = new System.Drawing.Size(87, 27);
            this.txtAlarmH.TabIndex = 7;
            // 
            // txtAlarmL
            // 
            this.txtAlarmL.Location = new System.Drawing.Point(59, 133);
            this.txtAlarmL.Name = "txtAlarmL";
            this.txtAlarmL.Size = new System.Drawing.Size(87, 27);
            this.txtAlarmL.TabIndex = 6;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(59, 88);
            this.txtUnit.MaxLength = 4;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(87, 27);
            this.txtUnit.TabIndex = 5;
            // 
            // txtURV
            // 
            this.txtURV.Location = new System.Drawing.Point(59, 55);
            this.txtURV.Name = "txtURV";
            this.txtURV.Size = new System.Drawing.Size(87, 27);
            this.txtURV.TabIndex = 4;
            this.txtURV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtURV_KeyPress);
            // 
            // txtLRV
            // 
            this.txtLRV.Location = new System.Drawing.Point(59, 20);
            this.txtLRV.Name = "txtLRV";
            this.txtLRV.Size = new System.Drawing.Size(87, 27);
            this.txtLRV.TabIndex = 3;
            this.txtLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLRV_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "URV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "LRV";
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(425, 317);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(125, 29);
            this.BtnReg.TabIndex = 3;
            this.BtnReg.Text = "Register New";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // txtRegistered
            // 
            this.txtRegistered.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegistered.Location = new System.Drawing.Point(567, 14);
            this.txtRegistered.Multiline = true;
            this.txtRegistered.Name = "txtRegistered";
            this.txtRegistered.ReadOnly = true;
            this.txtRegistered.Size = new System.Drawing.Size(125, 273);
            this.txtRegistered.TabIndex = 16;
            // 
            // group1
            // 
            this.group1.Controls.Add(this.BtnDelete);
            this.group1.Controls.Add(this.BtnSaveChanges);
            this.group1.Controls.Add(this.BtnRegisterNew);
            this.group1.Location = new System.Drawing.Point(410, 217);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(151, 94);
            this.group1.TabIndex = 15;
            this.group1.TabStop = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.Location = new System.Drawing.Point(25, 68);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(74, 24);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.AutoSize = true;
            this.BtnSaveChanges.Location = new System.Drawing.Point(25, 38);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(121, 24);
            this.BtnSaveChanges.TabIndex = 1;
            this.BtnSaveChanges.Text = "Save Changes";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // BtnRegisterNew
            // 
            this.BtnRegisterNew.AutoSize = true;
            this.BtnRegisterNew.Checked = true;
            this.BtnRegisterNew.Location = new System.Drawing.Point(25, 10);
            this.BtnRegisterNew.Name = "BtnRegisterNew";
            this.BtnRegisterNew.Size = new System.Drawing.Size(115, 24);
            this.BtnRegisterNew.TabIndex = 0;
            this.BtnRegisterNew.TabStop = true;
            this.BtnRegisterNew.Text = "Register new";
            this.BtnRegisterNew.UseVisualStyleBackColor = true;
            this.BtnRegisterNew.Click += new System.EventHandler(this.BtnRegisterNew_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(154, 257);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(250, 89);
            this.txtComment.TabIndex = 13;
            this.txtComment.MouseHover += new System.EventHandler(this.txtComment_MouseHover);
            // 
            // listOptions
            // 
            this.listOptions.FormattingEnabled = true;
            this.listOptions.ItemHeight = 20;
            this.listOptions.Items.AddRange(new object[] {
            "None",
            "HART-Protocol"});
            this.listOptions.Location = new System.Drawing.Point(154, 205);
            this.listOptions.Name = "listOptions";
            this.listOptions.Size = new System.Drawing.Size(150, 44);
            this.listOptions.TabIndex = 12;
            this.listOptions.MouseHover += new System.EventHandler(this.listOptions_MouseHover);
            // 
            // comboSignalType
            // 
            this.comboSignalType.FormattingEnabled = true;
            this.comboSignalType.Items.AddRange(new object[] {
            "Analog",
            "Digital",
            "Fieldbus"});
            this.comboSignalType.Location = new System.Drawing.Point(155, 135);
            this.comboSignalType.Name = "comboSignalType";
            this.comboSignalType.Size = new System.Drawing.Size(151, 28);
            this.comboSignalType.TabIndex = 10;
            this.comboSignalType.SelectedValueChanged += new System.EventHandler(this.comboSignalType_SelectedValueChanged);
            this.comboSignalType.MouseHover += new System.EventHandler(this.comboSignalType_MouseHover);
            // 
            // dTpRegDate
            // 
            this.dTpRegDate.Location = new System.Drawing.Point(154, 102);
            this.dTpRegDate.Name = "dTpRegDate";
            this.dTpRegDate.Size = new System.Drawing.Size(250, 27);
            this.dTpRegDate.TabIndex = 9;
            this.dTpRegDate.MouseHover += new System.EventHandler(this.dTpRegDate_MouseHover);
            // 
            // checkRegistered
            // 
            this.checkRegistered.AutoSize = true;
            this.checkRegistered.Location = new System.Drawing.Point(155, 79);
            this.checkRegistered.Name = "checkRegistered";
            this.checkRegistered.Size = new System.Drawing.Size(18, 17);
            this.checkRegistered.TabIndex = 8;
            this.checkRegistered.UseVisualStyleBackColor = true;
            this.checkRegistered.MouseHover += new System.EventHandler(this.checkRegistered_MouseHover);
            // 
            // MtxtSerialNumber
            // 
            this.MtxtSerialNumber.Location = new System.Drawing.Point(155, 46);
            this.MtxtSerialNumber.Mask = "000-00-0000";
            this.MtxtSerialNumber.Name = "MtxtSerialNumber";
            this.MtxtSerialNumber.Size = new System.Drawing.Size(125, 27);
            this.MtxtSerialNumber.TabIndex = 7;
            this.MtxtSerialNumber.MouseHover += new System.EventHandler(this.MtxtSerialNumber_MouseHover);
            // 
            // txtSensorName
            // 
            this.txtSensorName.Location = new System.Drawing.Point(155, 14);
            this.txtSensorName.Name = "txtSensorName";
            this.txtSensorName.PasswordChar = '*';
            this.txtSensorName.Size = new System.Drawing.Size(125, 27);
            this.txtSensorName.TabIndex = 6;
            this.txtSensorName.MouseHover += new System.EventHandler(this.txtSensorName_MouseHover);
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Location = new System.Drawing.Point(22, 257);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(74, 20);
            this.LblComment.TabIndex = 6;
            this.LblComment.Text = "Comment";
            // 
            // LblOptions
            // 
            this.LblOptions.AutoSize = true;
            this.LblOptions.Location = new System.Drawing.Point(22, 205);
            this.LblOptions.Name = "LblOptions";
            this.LblOptions.Size = new System.Drawing.Size(61, 20);
            this.LblOptions.TabIndex = 5;
            this.LblOptions.Text = "Options";
            // 
            // LblSignalType
            // 
            this.LblSignalType.AutoSize = true;
            this.LblSignalType.Location = new System.Drawing.Point(22, 147);
            this.LblSignalType.Name = "LblSignalType";
            this.LblSignalType.Size = new System.Drawing.Size(85, 20);
            this.LblSignalType.TabIndex = 4;
            this.LblSignalType.Text = "Signal Type";
            // 
            // LblRegDate
            // 
            this.LblRegDate.AutoSize = true;
            this.LblRegDate.Location = new System.Drawing.Point(22, 117);
            this.LblRegDate.Name = "LblRegDate";
            this.LblRegDate.Size = new System.Drawing.Size(74, 20);
            this.LblRegDate.TabIndex = 3;
            this.LblRegDate.Text = "Reg. Date";
            // 
            // LblRegistered
            // 
            this.LblRegistered.AutoSize = true;
            this.LblRegistered.Location = new System.Drawing.Point(22, 79);
            this.LblRegistered.Name = "LblRegistered";
            this.LblRegistered.Size = new System.Drawing.Size(80, 20);
            this.LblRegistered.TabIndex = 2;
            this.LblRegistered.Text = "Registered";
            // 
            // LblSerialNumber
            // 
            this.LblSerialNumber.AutoSize = true;
            this.LblSerialNumber.Location = new System.Drawing.Point(22, 49);
            this.LblSerialNumber.Name = "LblSerialNumber";
            this.LblSerialNumber.Size = new System.Drawing.Size(104, 20);
            this.LblSerialNumber.TabIndex = 1;
            this.LblSerialNumber.Text = "Serial Number";
            // 
            // LblSensorName
            // 
            this.LblSensorName.AutoSize = true;
            this.LblSensorName.Location = new System.Drawing.Point(22, 14);
            this.LblSensorName.Name = "LblSensorName";
            this.LblSensorName.Size = new System.Drawing.Size(97, 20);
            this.LblSensorName.TabIndex = 0;
            this.LblSensorName.Text = "Sensor Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtComReceived);
            this.tabPage2.Controls.Add(this.btnDisconnect);
            this.tabPage2.Controls.Add(this.btnComConnect);
            this.tabPage2.Controls.Add(this.txtBaudRate);
            this.tabPage2.Controls.Add(this.txtComPort);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtSend);
            this.tabPage2.Controls.Add(this.btnReadscaled);
            this.tabPage2.Controls.Add(this.btnReadstate);
            this.tabPage2.Controls.Add(this.btnWriteconfig);
            this.tabPage2.Controls.Add(this.btnReadconfig);
            this.tabPage2.Controls.Add(this.txtCommunication);
            this.tabPage2.Controls.Add(this.checkStayConnected);
            this.tabPage2.Controls.Add(this.txtPort);
            this.tabPage2.Controls.Add(this.txtIPAddress);
            this.tabPage2.Controls.Add(this.btnConnect);
            this.tabPage2.Controls.Add(this.labelPort);
            this.tabPage2.Controls.Add(this.labelIPAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtComReceived
            // 
            this.txtComReceived.Location = new System.Drawing.Point(703, 37);
            this.txtComReceived.Multiline = true;
            this.txtComReceived.Name = "txtComReceived";
            this.txtComReceived.Size = new System.Drawing.Size(125, 289);
            this.txtComReceived.TabIndex = 23;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(472, 204);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(94, 29);
            this.btnDisconnect.TabIndex = 22;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnComConnect
            // 
            this.btnComConnect.Location = new System.Drawing.Point(471, 162);
            this.btnComConnect.Name = "btnComConnect";
            this.btnComConnect.Size = new System.Drawing.Size(94, 29);
            this.btnComConnect.TabIndex = 21;
            this.btnComConnect.Text = "Connect";
            this.btnComConnect.UseVisualStyleBackColor = true;
            this.btnComConnect.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.FormattingEnabled = true;
            this.txtBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600"});
            this.txtBaudRate.Location = new System.Drawing.Point(526, 76);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(151, 28);
            this.txtBaudRate.TabIndex = 20;
            // 
            // txtComPort
            // 
            this.txtComPort.FormattingEnabled = true;
            this.txtComPort.Location = new System.Drawing.Point(526, 36);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(151, 28);
            this.txtComPort.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Baud Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Com Port";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(92, 164);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(125, 27);
            this.txtSend.TabIndex = 16;
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            // 
            // btnReadscaled
            // 
            this.btnReadscaled.Location = new System.Drawing.Point(227, 297);
            this.btnReadscaled.Name = "btnReadscaled";
            this.btnReadscaled.Size = new System.Drawing.Size(149, 29);
            this.btnReadscaled.TabIndex = 15;
            this.btnReadscaled.Text = "Read Scaled";
            this.btnReadscaled.UseVisualStyleBackColor = true;
            this.btnReadscaled.Click += new System.EventHandler(this.btnReadscaled_Click);
            // 
            // btnReadstate
            // 
            this.btnReadstate.Location = new System.Drawing.Point(227, 262);
            this.btnReadstate.Name = "btnReadstate";
            this.btnReadstate.Size = new System.Drawing.Size(149, 29);
            this.btnReadstate.TabIndex = 14;
            this.btnReadstate.Text = "Read state";
            this.btnReadstate.UseVisualStyleBackColor = true;
            this.btnReadstate.Click += new System.EventHandler(this.btnReadstate_Click);
            // 
            // btnWriteconfig
            // 
            this.btnWriteconfig.Location = new System.Drawing.Point(16, 297);
            this.btnWriteconfig.Name = "btnWriteconfig";
            this.btnWriteconfig.Size = new System.Drawing.Size(165, 29);
            this.btnWriteconfig.TabIndex = 13;
            this.btnWriteconfig.Text = "Write Configuration";
            this.btnWriteconfig.UseVisualStyleBackColor = true;
            this.btnWriteconfig.Click += new System.EventHandler(this.btnWriteconfig_Click);
            // 
            // btnReadconfig
            // 
            this.btnReadconfig.Location = new System.Drawing.Point(16, 262);
            this.btnReadconfig.Name = "btnReadconfig";
            this.btnReadconfig.Size = new System.Drawing.Size(165, 29);
            this.btnReadconfig.TabIndex = 12;
            this.btnReadconfig.Text = "Read Configuration";
            this.btnReadconfig.UseVisualStyleBackColor = true;
            this.btnReadconfig.Click += new System.EventHandler(this.btnReadconfig_Click);
            // 
            // txtCommunication
            // 
            this.txtCommunication.Location = new System.Drawing.Point(249, 36);
            this.txtCommunication.Multiline = true;
            this.txtCommunication.Name = "txtCommunication";
            this.txtCommunication.ReadOnly = true;
            this.txtCommunication.Size = new System.Drawing.Size(127, 213);
            this.txtCommunication.TabIndex = 11;
            // 
            // checkStayConnected
            // 
            this.checkStayConnected.AutoSize = true;
            this.checkStayConnected.Location = new System.Drawing.Point(56, 119);
            this.checkStayConnected.Name = "checkStayConnected";
            this.checkStayConnected.Size = new System.Drawing.Size(134, 24);
            this.checkStayConnected.TabIndex = 7;
            this.checkStayConnected.Text = "Stay Connected";
            this.checkStayConnected.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(92, 75);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(125, 27);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "5000";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(92, 33);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(125, 27);
            this.txtIPAddress.TabIndex = 5;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(92, 220);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 29);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(16, 78);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 20);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(16, 36);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(78, 20);
            this.labelIPAddress.TabIndex = 0;
            this.labelIPAddress.Text = "IP Address";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxServer);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(936, 352);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxServer
            // 
            this.listBoxServer.FormattingEnabled = true;
            this.listBoxServer.ItemHeight = 20;
            this.listBoxServer.Location = new System.Drawing.Point(6, 6);
            this.listBoxServer.Name = "listBoxServer";
            this.listBoxServer.Size = new System.Drawing.Size(657, 324);
            this.listBoxServer.TabIndex = 2;
            // 
            // tabSignal
            // 
            this.tabSignal.Controls.Add(this.btnStopMonitoring);
            this.tabSignal.Controls.Add(this.btnStartRecording);
            this.tabSignal.Controls.Add(this.chart1);
            this.tabSignal.Location = new System.Drawing.Point(4, 29);
            this.tabSignal.Name = "tabSignal";
            this.tabSignal.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignal.Size = new System.Drawing.Size(936, 352);
            this.tabSignal.TabIndex = 3;
            this.tabSignal.Text = "Signals";
            this.tabSignal.UseVisualStyleBackColor = true;
            // 
            // btnStopMonitoring
            // 
            this.btnStopMonitoring.Location = new System.Drawing.Point(738, 64);
            this.btnStopMonitoring.Name = "btnStopMonitoring";
            this.btnStopMonitoring.Size = new System.Drawing.Size(161, 29);
            this.btnStopMonitoring.TabIndex = 2;
            this.btnStopMonitoring.Text = "Stop Monitoring";
            this.btnStopMonitoring.UseVisualStyleBackColor = true;
            this.btnStopMonitoring.Click += new System.EventHandler(this.btnStopMonitoring_Click);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Location = new System.Drawing.Point(739, 17);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(160, 29);
            this.btnStartRecording.TabIndex = 1;
            this.btnStartRecording.Text = "Start Monitoring";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(31, 17);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(679, 309);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(958, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Ready...";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(59, 20);
            this.toolStripStatusLabel.Text = "Ready...";
            // 
            // timeReadScaled
            // 
            this.timeReadScaled.Interval = 5000;
            this.timeReadScaled.Tick += new System.EventHandler(this.timeReadScaled_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sensorData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning from tutorial";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sensorData.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabSignal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl sensorData;
        private TabPage tabPage1;
        private ComboBox comboSignalType;
        private DateTimePicker dTpRegDate;
        private CheckBox checkRegistered;
        private MaskedTextBox MtxtSerialNumber;
        private TextBox txtSensorName;
        private Label LblComment;
        private Label LblOptions;
        private Label LblSignalType;
        private Label LblRegDate;
        private Label LblRegistered;
        private Label LblSerialNumber;
        private Label LblSensorName;
        private TabPage tabPage2;
        private GroupBox group1;
        private RadioButton BtnDelete;
        private RadioButton BtnSaveChanges;
        private RadioButton BtnRegisterNew;
        private TextBox txtComment;
        private ListBox listOptions;
        private Button BtnReg;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private TextBox txtRegistered;
        private GroupBox group2;
        private ComboBox comboMeasureType;
        private Label label1;
        private TextBox txtUnit;
        private TextBox txtURV;
        private TextBox txtLRV;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox txtSummary;
        private TextBox txtPort;
        private TextBox txtIPAddress;
        private Button btnConnect;
        private Label labelPort;
        private Label labelIPAddress;
        private TabPage tabPage3;
        private CheckBox checkStayConnected;
        private ListBox listBoxServer;
        private TextBox txtCommunication;
        private Button btnReadscaled;
        private Button btnReadstate;
        private Button btnWriteconfig;
        private Button btnReadconfig;
        private TextBox txtSend;
        private ComboBox txtComPort;
        private Label label6;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtComReceived;
        private Button btnDisconnect;
        private Button btnComConnect;
        private ComboBox txtBaudRate;
        private TabPage tabSignal;
        private Label label8;
        private Label label7;
        private TextBox txtAlarmH;
        private TextBox txtAlarmL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btnStartRecording;
        private Button btnStopMonitoring;
        private System.Windows.Forms.Timer timeReadScaled;
    }
}