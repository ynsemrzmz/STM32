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

namespace usart
{
    public partial class USART : Form
    {
        public USART()
        {
            InitializeComponent();
        }

        private void init_ports()
        {
            string[] ports;
            string[] baudRates = { "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200" };

            ports = SerialPort.GetPortNames();
            
            foreach(string port in ports)
            {
                comboBoxPorts.Items.Add(port);
            }

            foreach(string baudRate in baudRates)
            {
                comboBoxBaudRates.Items.Add(baudRate);
            }

            labelConnStat.Text = "Disconnected";
            labelConnStat.ForeColor = Color.Red;

        }

        private void init_gpio_stats()
        {
            labelGPIOStat1.Text = "Reset";
            labelGPIOStat1.ForeColor = Color.Red;

            labelGPIOStat2.Text = "Reset";
            labelGPIOStat2.ForeColor = Color.Red;

            labelGPIOStat3.Text = "Reset";
            labelGPIOStat3.ForeColor = Color.Red;
        }

        private void connect()
        {
            if (!serialPortConnection.IsOpen)
            {
                try
                {
                    if (comboBoxBaudRates.SelectedItem != null && comboBoxPorts.SelectedItem != null)
                    {
                        serialPortConnection.PortName = comboBoxPorts.SelectedItem.ToString();
                        serialPortConnection.BaudRate = Convert.ToInt32(comboBoxBaudRates.SelectedItem);
                        serialPortConnection.Open();
                        labelConnStat.Text = "Open";
                        labelConnStat.ForeColor = Color.Green;


                    }
                    else
                    {
                        MessageBox.Show("Please select port and baud rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Connection is already open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnect()
        {
            if (serialPortConnection.IsOpen)
            {
                serialPortConnection.DiscardInBuffer();
                try
                {
                    serialPortConnection.Close();
                    labelConnStat.Text = "Disconnected";
                    labelConnStat.ForeColor = Color.Red;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data acquisiton has stopped", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Connection is already close", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void send_set_data1() {
            serialPortConnection.Write("A1");
            labelGPIOStat1.Text = "Set";
            labelGPIOStat1.ForeColor = Color.Green;

        }

        private void send_reset_data1()
        {
            serialPortConnection.Write("A0");
            labelGPIOStat1.Text = "Reset";
            labelGPIOStat1.ForeColor = Color.Red;
        }
        
        /*****************************************/

        private void send_set_data2()
        {
            serialPortConnection.Write("B1");
            labelGPIOStat2.Text = "Set";
            labelGPIOStat2.ForeColor = Color.Green;
        }

        private void send_reset_data2()
        {
            serialPortConnection.Write("B0");
            labelGPIOStat2.Text = "Reset";
            labelGPIOStat2.ForeColor = Color.Red;
        }

        /******************************************/

        private void send_set_data3()
        {
            serialPortConnection.Write("C1");
            labelGPIOStat3.Text = "Set";
            labelGPIOStat3.ForeColor = Color.Green;
        }

        private void send_reset_data3()
        {
            serialPortConnection.Write("C0");
            labelGPIOStat3.Text = "Reset";
            labelGPIOStat3.ForeColor = Color.Red;
        }

        /******************************************/


        private void USART_Load(object sender, EventArgs e)
        {
            init_ports();
            init_gpio_stats();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            disconnect(); 
        }

        private void buttonSet1_Click(object sender, EventArgs e)
        {
            send_set_data1();
        }

        private void buttonReset1_Click(object sender, EventArgs e)
        {
            send_reset_data1();
        }

        private void buttonSet2_Click(object sender, EventArgs e)
        {
            send_set_data2();
        }

        private void buttonReset2_Click(object sender, EventArgs e)
        {
            send_reset_data2();
        }

        private void buttonSet3_Click(object sender, EventArgs e)
        {
            send_set_data3();
        }

        private void buttonReset3_Click(object sender, EventArgs e)
        {
            send_reset_data3();
        }

        

        
    }
}
