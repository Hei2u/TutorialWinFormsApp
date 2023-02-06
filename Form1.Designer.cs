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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRegistered = new System.Windows.Forms.TextBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.BtnReg = new System.Windows.Forms.Button();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.sensorData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.group1.SuspendLayout();
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
            // 
            // sensorData
            // 
            this.sensorData.Controls.Add(this.tabPage1);
            this.sensorData.Controls.Add(this.tabPage2);
            this.sensorData.Location = new System.Drawing.Point(2, 29);
            this.sensorData.Name = "sensorData";
            this.sensorData.SelectedIndex = 0;
            this.sensorData.Size = new System.Drawing.Size(944, 385);
            this.sensorData.TabIndex = 1;
            // 
            // tabPage1
            // 
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
            // txtRegistered
            // 
            this.txtRegistered.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegistered.Location = new System.Drawing.Point(567, 14);
            this.txtRegistered.Multiline = true;
            this.txtRegistered.Name = "txtRegistered";
            this.txtRegistered.ReadOnly = true;
            this.txtRegistered.Size = new System.Drawing.Size(125, 308);
            this.txtRegistered.TabIndex = 16;
            // 
            // group1
            // 
            this.group1.Controls.Add(this.BtnDelete);
            this.group1.Controls.Add(this.BtnSaveChanges);
            this.group1.Controls.Add(this.BtnRegisterNew);
            this.group1.Location = new System.Drawing.Point(410, 163);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(151, 124);
            this.group1.TabIndex = 15;
            this.group1.TabStop = false;
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(425, 293);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(125, 29);
            this.BtnReg.TabIndex = 3;
            this.BtnReg.Text = "Register New";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.Location = new System.Drawing.Point(25, 97);
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
            this.BtnSaveChanges.Location = new System.Drawing.Point(25, 62);
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
            this.BtnRegisterNew.Location = new System.Drawing.Point(25, 26);
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
            this.txtComment.Location = new System.Drawing.Point(154, 233);
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
            this.listOptions.Location = new System.Drawing.Point(154, 177);
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
            this.comboSignalType.Location = new System.Drawing.Point(154, 143);
            this.comboSignalType.Name = "comboSignalType";
            this.comboSignalType.Size = new System.Drawing.Size(151, 28);
            this.comboSignalType.TabIndex = 11;
            this.comboSignalType.MouseHover += new System.EventHandler(this.comboSignalType_MouseHover);
            // 
            // dTpRegDate
            // 
            this.dTpRegDate.Location = new System.Drawing.Point(154, 110);
            this.dTpRegDate.Name = "dTpRegDate";
            this.dTpRegDate.Size = new System.Drawing.Size(250, 27);
            this.dTpRegDate.TabIndex = 10;
            this.dTpRegDate.MouseHover += new System.EventHandler(this.dTpRegDate_MouseHover);
            // 
            // checkRegistered
            // 
            this.checkRegistered.AutoSize = true;
            this.checkRegistered.Location = new System.Drawing.Point(154, 86);
            this.checkRegistered.Name = "checkRegistered";
            this.checkRegistered.Size = new System.Drawing.Size(18, 17);
            this.checkRegistered.TabIndex = 9;
            this.checkRegistered.UseVisualStyleBackColor = true;
            this.checkRegistered.MouseHover += new System.EventHandler(this.checkRegistered_MouseHover);
            // 
            // MtxtSerialNumber
            // 
            this.MtxtSerialNumber.Location = new System.Drawing.Point(155, 53);
            this.MtxtSerialNumber.Mask = "000-00-0000";
            this.MtxtSerialNumber.Name = "MtxtSerialNumber";
            this.MtxtSerialNumber.Size = new System.Drawing.Size(125, 27);
            this.MtxtSerialNumber.TabIndex = 8;
            this.MtxtSerialNumber.MouseHover += new System.EventHandler(this.MtxtSerialNumber_MouseHover);
            // 
            // txtSensorName
            // 
            this.txtSensorName.Location = new System.Drawing.Point(155, 20);
            this.txtSensorName.Name = "txtSensorName";
            this.txtSensorName.Size = new System.Drawing.Size(125, 27);
            this.txtSensorName.TabIndex = 7;
            this.txtSensorName.MouseHover += new System.EventHandler(this.txtSensorName_MouseHover);
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Location = new System.Drawing.Point(22, 230);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(74, 20);
            this.LblComment.TabIndex = 6;
            this.LblComment.Text = "Comment";
            // 
            // LblOptions
            // 
            this.LblOptions.AutoSize = true;
            this.LblOptions.Location = new System.Drawing.Point(22, 185);
            this.LblOptions.Name = "LblOptions";
            this.LblOptions.Size = new System.Drawing.Size(61, 20);
            this.LblOptions.TabIndex = 5;
            this.LblOptions.Text = "Options";
            // 
            // LblSignalType
            // 
            this.LblSignalType.AutoSize = true;
            this.LblSignalType.Location = new System.Drawing.Point(17, 152);
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
            this.LblRegistered.Location = new System.Drawing.Point(22, 86);
            this.LblRegistered.Name = "LblRegistered";
            this.LblRegistered.Size = new System.Drawing.Size(80, 20);
            this.LblRegistered.TabIndex = 2;
            this.LblRegistered.Text = "Registered";
            // 
            // LblSerialNumber
            // 
            this.LblSerialNumber.AutoSize = true;
            this.LblSerialNumber.Location = new System.Drawing.Point(22, 56);
            this.LblSerialNumber.Name = "LblSerialNumber";
            this.LblSerialNumber.Size = new System.Drawing.Size(104, 20);
            this.LblSerialNumber.TabIndex = 1;
            this.LblSerialNumber.Text = "Serial Number";
            // 
            // LblSensorName
            // 
            this.LblSensorName.AutoSize = true;
            this.LblSensorName.Location = new System.Drawing.Point(22, 20);
            this.LblSensorName.Name = "LblSensorName";
            this.LblSensorName.Size = new System.Drawing.Size(97, 20);
            this.LblSensorName.TabIndex = 0;
            this.LblSensorName.Text = "Sensor Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // group2
            // 
            this.group2.Location = new System.Drawing.Point(410, 14);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(151, 143);
            this.group2.TabIndex = 14;
            this.group2.TabStop = false;
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
            this.TopMost = true;
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
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
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
    }
}