using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        
        string operation = " ";
        bool operation_pressed = false;
        string secondnum,q;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (operation_pressed))
            {
                textBox_Result.Clear();
            }

            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + b.Text;
            }
            else

                textBox_Result.Text = textBox_Result.Text + b.Text;
        }

        private void button17_On_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            equation.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox_Result.Text);
            operation_pressed = true;
            equation.Text = value + " " +  operation ;
            q = equation.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            secondnum = textBox_Result.Text;
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    textBox_Result.Text = (value + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (value - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (value * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (value / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                
                default:
                    break;
            }
            operation_pressed = false;
            button13_ClearHistory.Visible = true;
            txt_DisplayHistory.AppendText( q+ " " + secondnum + "=");
            txt_DisplayHistory.AppendText(equation.Text+ "\n"); //+ " " + textBox_Result.Text);
            ///txt_DisplayHistory.Text = " ";

        }
         

        private void button18_Clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
            value = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            double a;
            a = Convert.ToDouble(textBox_Result.Text) / Convert.ToDouble(100);
            textBox_Result.Text = System.Convert.ToString(a);
            
        }

        private void button13_ClearHistory_Click(object sender, EventArgs e)
        {
            txt_DisplayHistory.Clear();
        }

        private void equation_Click(object sender, EventArgs e)
        {
            equation.Text = value + " " + operation;
        }

        
    }
}
