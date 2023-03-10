using System.Diagnostics;
using System.Globalization;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TutorialWinFormsApp
{
    public partial class Form1 : Form
    {
        DateTime startTime = DateTime.Now;
        string[] analogSignals = new string[] { "0-5VDC", "0-10VDC", "0-15VDC", "0-20VDC" };
        string[] digitalSignals = new string[] { "5VDC", "10VDC", "15VDC", "20VDC" };
        string[] fieldbusSignals = new string[] { "Modus1", "Modus2", "Modus3" };

        uint reg = 0;
        uint nrDigital = 0;
        uint nrAnalog = 0;
        uint nrFieldbus = 0;

        //uint i = 0;

        //bool monitor = false;

        //static SerialPort serialPort;

        //string[] servers = new string[] {""};
        List<string> servers = new List<string>();
        List<Instrument> instrumentList = new List<Instrument>(); //tok vekk public
        public Form1()
        {
            
            InitializeComponent();

            /*
            string[] ComPorts = System.IO.Ports.SerialPort.GetPortNames();
            txtComPort.Items.AddRange(ComPorts);

            serialPort = new SerialPort();
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;
            serialPort.DataReceived += dataReceived;
            */

            /*
            IPAddress[] addresslist = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in addresslist)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    servers.Add(address.ToString());
                }
            }
            //comboMeasureType.Items.AddRange(analogSignals);
            listBoxServer.Items.AddRange(servers.ToArray());
            */
            
        }

        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string message = serialPort.ReadLine();
            //txtComReceived.AppendText(message);
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
            /*if (e.KeyChar == '+')
            {
                this.Width += 20;
                this.Height += 15;
            }
            if (e.KeyChar =='-')
            {
                this.Width -= 20;  
                this.Height -= 15;
            }
            */
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
            switch (BtnReg.Text)
            {
                case "Register New":
                    if (!NewSensorName()) break;
                    if  (comboSignalType.SelectedItem == "Analog")
                    {
                        if (txtURV.TextLength <= 0 | txtLRV.TextLength <= 0)
                        {
                            MessageBox.Show("Missing Range");
                            return;
                        }
                        Instrument instrument = new Instrument(txtSensorName.Text,
                            MtxtSerialNumber.Text,
                            comboSignalType.Text,
                            comboMeasureType.Text,
                            listOptions.SelectedIndex.ToString(), //vet ikke om det er riktig at denne gir et tall
                            txtComment.Text,
                            Convert.ToDouble(txtLRV.Text),
                            Convert.ToDouble(txtURV.Text),
                            txtUnit.Text);
                        nrAnalog += 1;
                        listBoxServer.Items.Add(instrument.ToString());
                        instrumentList.Add(instrument);
                    }
                    else if (comboSignalType.SelectedItem == "Digital")
                    {
                        nrDigital += 1;
                        Instrument instrument = new Instrument(txtSensorName.Text,
                            MtxtSerialNumber.Text,
                            comboSignalType.Text,
                            comboMeasureType.Text,
                            listOptions.SelectedIndex.ToString(), //vet ikke om det er riktig at denne gir et tall
                            txtComment.Text);
                        listBoxServer.Items.Add(instrument.ToString());
                        instrumentList.Add(instrument);
                    }
                    else
                    {
                        nrFieldbus += 1;
                        Instrument instrument = new Instrument(txtSensorName.Text,
                            MtxtSerialNumber.Text,
                            comboSignalType.Text,
                            comboMeasureType.Text,
                            listOptions.SelectedIndex.ToString(), //vet ikke om det er riktig at denne gir et tall
                            txtComment.Text);
                        listBoxServer.Items.Add(instrument.ToString());
                        instrumentList.Add(instrument);
                    }
                    

                    
                    Reset_input();
                    break;
                case "Save Changes":
                    Reset_input();
                    //vet ikke hvordan jeg skal "override" dette
                    break;
                case "Delete":
                    Reset_input();
                    //Vet ikke hvordan jeg skal gjøre dette heller
                    break;
            }
            /*
            if (BtnRegisterNew.Checked)
            {
                if (comboSignalType.SelectedItem == "Analog")
                {
                    if (txtURV.TextLength <= 0 | txtLRV.TextLength <= 0)
                    {
                        MessageBox.Show("Missing Range");
                        return;
                    }
                    nrAnalog += 1;
                }
                else if (comboSignalType.SelectedItem == "Digital")
                {
                    nrDigital += 1;
                }
                else
                {
                    nrFieldbus += 1;
                }
                Sensor_method();
                Reset_input();
                
                reg += 1;
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
            */
        }

        private void Reset_input()
        {
            txtSensorName.Text = "";
            MtxtSerialNumber.Text = "";
            checkRegistered.Checked = false;
            dTpRegDate.Value = DateTime.Now;
            comboMeasureType.Text = "";
            comboSignalType.Text = "";
            listOptions.Text = "";
            txtComment.Text = "";
            if (comboSignalType.SelectedItem == "Analog")
            {
                txtLRV.Text = "";
                txtURV.Text = "";
                txtUnit.Text = "";
            }
        }

        private void Sensor_method()
        {
            txtRegistered.AppendText("Sensor Name: " + txtSensorName.Text + "\r\n");
            txtRegistered.AppendText("Serial Number: " + MtxtSerialNumber.Text + "\r\n");
            txtRegistered.AppendText("Registered: " + checkRegistered.CheckState + "\r\n");
            txtRegistered.AppendText("Register Date: " + dTpRegDate.Value + "\r\n");
            txtRegistered.AppendText("Signal Type: " + comboMeasureType.Text + "\r\n");
            txtRegistered.AppendText("Measure Type: " + comboSignalType.Text + "\r\n");
            txtRegistered.AppendText("Options: " + listOptions.Text + "\r\n");
            txtRegistered.AppendText("Comment: " + txtComment.Text + "\r\n");
            if (comboSignalType.SelectedItem == "Analog")
            {
                float range = float.Parse(txtURV.Text, CultureInfo.InvariantCulture.NumberFormat) - float.Parse(txtLRV.Text, CultureInfo.InvariantCulture.NumberFormat);
                //float.Parse(strFloatValue, CultureInfo.InvariantCulture.NumberFormat)
                txtRegistered.AppendText("LRV: " + txtLRV.Text + "\r\n");
                txtRegistered.AppendText("URV: " + txtURV.Text + "\r\n");
                txtRegistered.AppendText("Unit: " + txtUnit.Text + "\r\n");
                txtRegistered.AppendText("Range: " + range + "\r\n");
            }
        }

        private void comboSignalType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboSignalType.SelectedItem == "Analog")
            {
                group2.Visible = true;

                comboMeasureType.Items.Clear();
                comboMeasureType.Items.AddRange(analogSignals);

            }
            else
            {
                group2.Visible = false;

                comboMeasureType.Items.Clear();
                if (comboSignalType.SelectedItem == "Digital")
                {
                    comboMeasureType.Items.AddRange(digitalSignals);
                }
                else
                {
                    comboMeasureType.Items.AddRange(fieldbusSignals);
                }
            }
        }

        private void txtLRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtURV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSummary.AppendText("Amount registered: " + reg.ToString() + "\r\n");
            txtSummary.AppendText("Analog sensors: " + nrAnalog.ToString() + "\r\n");
            txtSummary.AppendText("Digital sensors: " + nrDigital.ToString() + "\r\n");
            txtSummary.AppendText("Fieldbus sensors: " + nrFieldbus.ToString() + "\n\r");
            DateTime endTime = DateTime.Now;
            System.TimeSpan TimeDiff1 = endTime.Subtract(startTime);
            txtSummary.AppendText("time since sessien-start: " + TimeDiff1.TotalSeconds + "\r\n");
        }
        private bool NewSensorName()
        {
            bool newSensorName = true;
            instrumentList.ForEach(delegate (Instrument instr)
            {
                if(instr.SensorName == txtSensorName.Text)
                {
                    MessageBox.Show("Sensor Name already exists!");
                    newSensorName = false;
                    txtSensorName.Focus();
                }
            });
            return newSensorName;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //skal slettes

        }

        private string connectAndSend(string info)
        {
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(txtIPAddress.Text), Convert.ToInt32(txtPort.Text));
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(endpoint);
                txtCommunication.AppendText("Connected to server.");

                //client.Send(Encoding.ASCII.GetBytes(txtSend.Text));
                client.Send(Encoding.ASCII.GetBytes(info));
                //client.Send(Encoding.ASCII.GetBytes("readscaled"));

                byte[] buffer = new byte[1024];
                int bytesReceived = client.Receive(buffer);

                //txtCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived));
                string hele = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
                string[] words = hele.Split(';');
                //chart1.Series[0].Points.AddXY(i, words[1]);
                
                client.Close();
                txtCommunication.AppendText(hele);
                txtCommunication.AppendText("Disconnected from server.");
                return words[1];
            }
            catch
            {
                txtCommunication.AppendText("something went wrong");
                return "ups!";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }

        private void btnReadconfig_Click(object sender, EventArgs e)
        {
            string[] sensorConf;
            string recieved;
            connectAndSend("readconf");
            //send spørsmål om readconf til ConsoleApp
            //skriv svaret til txtCommunication

            /*
            client.Send(Encoding.ASCII.GetBytes(txtSend.Text));
            //client.Send(Encoding.ASCII.GetBytes("readscaled"));

            byte[] buffer = new byte[1024];
            int bytesReceived = client.Receive(buffer);
            txtCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived));
        */
        }

        private void txtSend_TextChanged(object sender, EventArgs e)
        {
            //send spørsmål om sensorconf til ConsoleApp
            //skriv svaret(recieved) til txtCommunication
        }

        private void btnReadstate_Click(object sender, EventArgs e)
        {
            string[] sensorConf;
            string recieved;
            connectAndSend("readstatus");
            // send spørsmål om readstate til ConsoleApp
            //skriv svaret(recieved) til txtCommunication
        }

        private void btnReadscaled_Click(object sender, EventArgs e)
        {
            string[] sensorConf;
            string recieved;
            connectAndSend("readscaled");
            // send spørsmål om readscaled til ConsoleApp
            //skriv svaret(recieved) til txtCommunication
        }

        private void btnWriteconfig_Click(object sender, EventArgs e)
        {
            //lage strengen som skal sendes
            string instrumentConfig = "";
            instrumentConfig = "writeconf>password>name" + 
                txtSensorName.Text + ";" +
                txtLRV.Text + ";" +
                txtURV.Text + ";" +
                txtAlarmL.Text + ";" +
                txtAlarmH + ";"; //legg til høy alarm og lav alarm når jeg har fått laget disse
            //og få noen til å send inn passord
            //se om det er analog
            connectAndSend(instrumentConfig);
        }

        private void btnConnect2_Click(object sender, EventArgs e)
        {
            /*
            //this is actually btnComConnect
            //txtComReceived.AppendText("Hei");
            if (txtComPort.Text != "")
            {
                serialPort.PortName = txtComPort.Text; //noe er galt
            }
            else
            {
                return;
            }
            if (txtBaudRate.Text != "")
            {
                serialPort.BaudRate = Convert.ToInt32(txtBaudRate.Text);
            }
            else
            {
                return;
            }
            serialPort.Open();
            serialPort.WriteLine(txtSend.Text);
            //serialPort.ReadLine();
            txtComReceived.AppendText(serialPort.ReadLine().ToString());
            */
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            //monitor = true;
            //string[] sensorConf;
            //string recieved;
            timeReadScaled.Start();
            //while (monitor)
            //{
                //string word = connectAndSend("readscaled");
                //chart1.Series[0].Points.AddXY(i, word);
                //i += 1;
                //Thread.Sleep(10000);
            //}
            //string word = connectAndSend("readscaled");
            //-chart1.Series[0].Points.AddXY(i, word);


            //chart1.Series[0].Points.AddXY(1.0, 1.0);
            //chart1.Series[0].Points.AddXY(4.5, 2.5);
        }

        private void btnStopMonitoring_Click(object sender, EventArgs e)
        {
            //monitor = false;
            timeReadScaled.Stop();
        }

        private void timeReadScaled_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            //txtSummary.AppendText(localDate);

            string word = connectAndSend("readscaled");
            chart1.Series[0].Points.AddXY(timeNow.ToString("mm:ss"), word);
            //i += 1;
        }
    }
}