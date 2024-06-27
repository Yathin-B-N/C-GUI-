using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ardiuno_GUI
{
    public partial class Form1 : Form
    {
        private string red,yellow,green;
        public delegate void d1(string indata);  //bridge btw 2 threads
        private static int counter;
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

       

        private void redval_Scroll(object sender, EventArgs e)
        {
            red = "R" + redval.Value;
        }

        private void Sendredval_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(red))
            {
                red = "R0";
            }
            serialPort1.Write(red);
        }

        private void redval_Scroll_1(object sender, EventArgs e)
        {
            red = "R" + redval.Value;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sendyellowval_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(yellow))
            {
                yellow = "Y0";
            }
            serialPort1.Write(yellow);
        }

        
        private void yellowval_Scroll_1(object sender, EventArgs e)
        {
            yellow = "Y" + yellowval.Value;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string indata = serialPort1.ReadLine();
            d1 writeit = new d1(Write2Form);
            Invoke(writeit, indata);
        }
        public void Write2Form(string indata)
        {
            //fun for reciving the data from adrino 
            char firstchar;
            Single numdata;
            firstchar = indata[0];
            switch (firstchar)
            {
                case 'p':
                    counter++;
                    textBox2.Text = Convert.ToString(counter);
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(green))
            {
                green = "G0";
            }
            serialPort1.Write(green);
        }

        private void greenval_Scroll(object sender, EventArgs e)
        {
            green = "G" + greenval.Value;
        }
    }
}
