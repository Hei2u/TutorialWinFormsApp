using System.Diagnostics;
using System.Windows.Forms;

namespace TutorialWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                this.Width += 20;
                this.Height += 15;
            }
            if (e.KeyChar =='-')
            {
                this.Width -= 20;  
                this.Height -= 15;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            /*this.Location = new Point(0, 0);*/
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void BtnRegisterNew_Click(object sender, EventArgs e)
        {
            BtnReg.Text = "Register New";
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            BtnReg.Text = "Save Changes";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            BtnReg.Text = "Delete";
        }

        private void tabPage1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Ready...";
        }

        private void txtSensorName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Enter Sensor Name";
        }

        private void MtxtSerialNumber_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Enter Serial Number";
        }

        private void checkRegistered_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Check if registered";
        }

        private void dTpRegDate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Enter Registered Date";
        }

        private void comboSignalType_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Enter Signal Type";
        }

        private void listOptions_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Enter Option";
        }

        private void txtComment_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Enter Comment";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            if (BtnRegisterNew.Checked)
            {
                Sensor_method();
                Reset_input();
            }
            else if (BtnSaveChanges.Checked) 
            {
                txtRegistered.Text = "";
                Sensor_method();
                Reset_input();
            }
            else
            {
                txtRegistered.Text = "";
                Reset_input();
            }
        }

        private void Reset_input()
        {
            txtSensorName.Text = "";
            MtxtSerialNumber.Text = "";
            checkRegistered.Checked = false;
            dTpRegDate.Value = DateTime.Now;
            comboSignalType.Text = "";
            listOptions.Text = "";
            txtComment.Text = "";
        }

        private void Sensor_method()
        {
            txtRegistered.AppendText("Sensor Name: " + txtSensorName.Text + "\r\n");
            txtRegistered.AppendText("Serial Number: " + MtxtSerialNumber.Text + "\r\n");
            txtRegistered.AppendText("Registered: " + checkRegistered.CheckState + "\r\n");
            txtRegistered.AppendText("Register Date: " + dTpRegDate.Value + "\r\n");
            txtRegistered.AppendText("Signal Type: " + comboSignalType.Text + "\r\n");
            txtRegistered.AppendText("Options: " + listOptions.Text + "\r\n");
            txtRegistered.AppendText("Comment: " + txtComment.Text + "\r\n");

            /*
             * if (comboBox1.Text == "Analog")
            {
                txtRegistered.AppendText("LRV: " + Nytt navn!.Text + "\r\n");
                txtRegistered.AppendText("URV: " + Nytt navn!.Text + "\r\n");
            }
            */
        }
    }
}