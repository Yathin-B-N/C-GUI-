using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caclulator_giu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string b = "3";
            textBox1.Text += b;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string b = "6";
            textBox1.Text += b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string b = "-";
            textBox1.Text += b; 
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            string a = "1";
            textBox1.Text += a;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string b = "2";
            textBox1.Text += b;

        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            string b = "+";
            textBox1.Text += b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string c = "4";
            textBox1.Text += c;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string d = "5";
            textBox1.Text += d;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string f = "7";
            textBox1.Text += f;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string b = "8";
            textBox1.Text += b;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string b = "9";
            textBox1.Text += b;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            string b = "*";
            textBox1.Text += b;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            string b = " ";
            textBox1.Text = b;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string b = "0";
            textBox1.Text += b;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {

            
              
                    Stack<string> sta = new Stack<string>();
                    string Ip = textBox1.Text;  

                    // Split the input into tokens (numbers and operators)
                    string number = "";
                    foreach (char c in Ip)
                    {
                        if (char.IsDigit(c) || c == '.')
                        {
                            number += c;
                        }
                        else
                        {
                            if (number != "")
                            {
                                sta.Push(number);
                                number = "";
                            }
                            if (c != ' ')
                            {
                                sta.Push(c.ToString());
                            }
                        }
                    }
                    if (number != "")
                    {
                        sta.Push(number);
                    }

                    float result = docal(sta);
                    textBox1.Text = result.ToString();


                
            
        }

        public float docal(Stack<string> sta)
        {
            Stack<char> operators = new Stack<char>();
            Stack<float> operands = new Stack<float>();


            while (sta.Count > 0)
        {
            string c = sta.Pop();

            if (char.IsDigit(c[0]) || (c[0] == '-' && c.Length > 1)) // Check for digits or negative multi-digit numbers
            {
                operands.Push(float.Parse(c)); // Convert string to float and push
            }
            else if (c.Length == 1) // Check if it's a single character operator
            {
                operators.Push(c[0]);
            }
        }

            while (operators.Count!=0)
            {
                float num1 = operands.Peek();
                operands.Pop();
                float num2 = operands.Peek(); operands.Pop();
                char op = operators.Peek();
                operators.Pop();

                float ans = getanswers(num1,op, num2);
                operands.Push(ans);


            }
            return operands.Peek();
        }

        public float getanswers(float num1, char op, float num2)
        {

            switch(op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        Console.WriteLine("zero division error");      
                        return 0;
                default:
                    Console.WriteLine("Invalid operator"); 
                    return 0;
            }

        }

        private void buttonDi_Click(object sender, EventArgs e)
        {
            string b = "/";
            textBox1.Text += b;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
