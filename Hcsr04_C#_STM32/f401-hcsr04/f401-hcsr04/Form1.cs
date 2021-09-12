using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;

namespace f401_hcsr04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void init_ports()
        {
            string[] ports;
            string[] baudRates = { "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200" };

            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPort.Items.Add(port);
            }

            foreach (string baudRate in baudRates)
            {
                comboBoxBaud.Items.Add(baudRate);
            }

        }

        private void connect()
        {
            if (!serialPort.IsOpen)
            {
                try
                {
                    if (comboBoxBaud.SelectedItem != null && comboBoxPort.SelectedItem != null)
                    {
                        serialPort.PortName = comboBoxPort.SelectedItem.ToString();
                        serialPort.BaudRate = Convert.ToInt32(comboBoxBaud.SelectedItem);
                        serialPort.Open();
                        labelConnectionStatus.Text = "Açık";
                        labelConnectionStatus.ForeColor = Color.Green;


                    }
                    else
                    {
                        MessageBox.Show("Lütfen port ve baud rate seçimini yapınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bağlantı zaten açık", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnect()
        {

            if (serialPort.IsOpen)
            {
                serialPort.DiscardInBuffer();
                try
                {
                    serialPort.Close();
                    labelConnectionStatus.Text = "Kapalı";
                    labelConnectionStatus.ForeColor = Color.Red;
                    labelData.Text = "Veri bekleniyor...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri Akışı Durduruldu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bağlantı zaten açık değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int map(int x, int in_min, int in_max, int out_min, int out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init_ports();

            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private  void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serial = (SerialPort)sender;

            string data = serial.ReadLine();
            labelData.Text = data.ToString();

        }

     
    }
}
