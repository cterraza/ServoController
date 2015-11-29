using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string RxString;
        String[] Puertos = System.IO.Ports.SerialPort.GetPortNames();
        byte[] bytesToSend = new byte[13] { 0x24, 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xAA, 0xBB };

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(listBox1.Text);
            timer1.Enabled = true;
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                textBox1.ReadOnly = false;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }


        private void DisplayText(object sender, EventArgs e)
        {
            textBox1.AppendText(RxString);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the port is closed, don't try to send a character.
            if (!serialPort1.IsOpen) return;

            // If the port is Open, declare a char[] array with one element.

            char[] buff = new char[1];

            // Load element 0 with the key character.
            buff[0] = e.KeyChar;

            // Send the one character buffer.
            serialPort1.Write(buff, 0, 1);

            // Set the KeyPress event as handled so the character won't
            // display locally. If you want it to display, omit the next line.

            e.Handled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
                textBox1.ReadOnly = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Puertos;
            label5.Text = Convert.ToString(hScrollBar1.Value);
            label6.Text = Convert.ToString(hScrollBar2.Value);
            label8.Text = Convert.ToString(hScrollBar3.Value);
            label7.Text = Convert.ToString(hScrollBar4.Value);
            label16.Text = Convert.ToString(hScrollBar5.Value);
            label15.Text = Convert.ToString(hScrollBar6.Value);
            label12.Text = Convert.ToString(hScrollBar7.Value);
            label11.Text = Convert.ToString(hScrollBar8.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] recbytes = new byte[2];
            bytesToSend[1] = Convert.ToByte(hScrollBar1.Value);
            bytesToSend[2] = Convert.ToByte(hScrollBar2.Value);
            bytesToSend[3] = Convert.ToByte(hScrollBar3.Value);
            bytesToSend[4] = Convert.ToByte(hScrollBar4.Value);
            bytesToSend[5] = Convert.ToByte(hScrollBar5.Value);
            bytesToSend[6] = Convert.ToByte(hScrollBar6.Value);
            bytesToSend[7] = Convert.ToByte(hScrollBar7.Value);
            bytesToSend[8] = Convert.ToByte(hScrollBar8.Value);
            recbytes[0] = Convert.ToByte((hScrollBar9.Value & 0x00FF));
            recbytes[1] = Convert.ToByte((hScrollBar9.Value & 0xFF00) >> 8);
            textBox1.AppendText(BitConverter.ToString(recbytes));
            serialPort1.Write(bytesToSend,0,13);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label5.Text = Convert.ToString(hScrollBar1.Value);
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            label7.Text = Convert.ToString(hScrollBar4.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label8.Text = Convert.ToString(hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label6.Text = Convert.ToString(hScrollBar2.Value);
        }

        private void hScrollBar8_Scroll(object sender, ScrollEventArgs e)
        {
            label11.Text = Convert.ToString(hScrollBar8.Value);
        }

        private void hScrollBar7_Scroll(object sender, ScrollEventArgs e)
        {
            label12.Text = Convert.ToString(hScrollBar7.Value);
        }

        private void hScrollBar6_Scroll(object sender, ScrollEventArgs e)
        {
            label15.Text = Convert.ToString(hScrollBar6.Value);
        }

        private void hScrollBar5_Scroll(object sender, ScrollEventArgs e)
        {
            label16.Text = Convert.ToString(hScrollBar5.Value);
        }
      
    }
}
