using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Z
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            t1.Text += "3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (t1.TextLength >= 1)
            {
                int length = t1.TextLength - 1;
                string text = t1.Text;
                t1.Clear();
                for (int i = 0; i < length; i++)
                {
                    t1.Text = t1.Text + text[i];

                }
            }
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            t1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (t1.Text.Contains("."))
            {
                return;
            }
            else
            {
                t1.Text += ".";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            t1.Text += "1";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            t1.Text += "2";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            t1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + 7;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            t1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(t1.Text);
            t1.Clear();
            t1.Focus();
            count = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(t1.Text);
            t1.Clear();
            t1.Focus();
            count = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(t1.Text);
            t1.Clear();
            t1.Focus();
            count =4 ;  
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(t1.Text);
            t1.Clear();
            t1.Focus();
            count = 2;
        }

        private void button18_Click(object sender, EventArgs e)
             {  
            compute(count);  
        }  
        public void compute(int count)  
        
        {
           switch(count)
           {
               case 1:
                   ans = num1 * float.Parse(t1.Text); 
                    MessageBox.Show("your answer is:",t1.Text = ans.ToString());  
                    break; 
               case 2:
                    ans = num1 - float.Parse(t1.Text);
                       t1.Text=ans.ToString();
                   break;
               case 3:
                   ans = num1 / float.Parse(t1.Text);
                   t1.Text = ans.ToString();
                   break;
           case 4:
                   ans = num1 + float.Parse(t1.Text);
                   t1.Text = ans.ToString();
                   break;

           }

        }

    }
    }