using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voltmeter
{
    public partial class Form1 : Form
    {
        String ArduData = "";
        String Ae = "";
        String be = "";
        String c = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void portcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void baudcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = portcmb.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudcmb.Text);
                serialPort1.Open();
                openbtn.Enabled = false;
                closedbtn.Enabled = true;
                timer1.Enabled = true;
                
            }
            catch(Exception errName)
            {
                MessageBox.Show(errName.ToString());
            }
        }

        private void closedbtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = portcmb.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudcmb.Text);
                serialPort1.Close();
                openbtn.Enabled = true;
                closedbtn.Enabled = false;
                timer1.Enabled = false;


            }
            catch (Exception errName)
            {
                MessageBox.Show(errName.ToString());
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            ArduData = serialPort1.ReadLine();
            Ae = ArduData.Substring(0,5);
            be = ArduData.Substring(5,7);
            c = ArduData.Substring(12);
          }

        private void timer1_Tick(object sender, EventArgs e)
        {
            volLbl.Text = Ae;
            resval.Text = be;
            currval.Text = c;
        }

        private void resval_Click(object sender, EventArgs e)
        {

        }
    }
}
