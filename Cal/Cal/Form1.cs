using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
          
        Double resultValue=0;
        String operation = "";
        bool isOperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBoxresult.Text=(resultValue + Double.Parse(textBoxresult.Text)).ToString();
                    break;
                case "-":
                    textBoxresult.Text = (resultValue - Double.Parse(textBoxresult.Text)).ToString();
                    break;
                case "*":
                    textBoxresult.Text = (resultValue - Double.Parse(textBoxresult.Text)).ToString();
                    break;
                case " /":
                    textBoxresult.Text = (resultValue / Double.Parse(textBoxresult.Text)).ToString();
                    break;
                    default:
                    break;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBoxresult.Text=String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            resultValue=Double.Parse(textBoxresult.Text);

            labelcurrentOpration.Text = resultValue + " " + operation;
            isOperation = true;
        }

        private void button123_Click(object sender, EventArgs e)
        {
            if((textBoxresult.Text=="0")||(isOperation))
            {
                textBoxresult.Text = "0";
            }
            isOperation = false;
            Button button = (Button)sender;
            textBoxresult.Text = textBoxresult.Text + button.Text;
        }
    }
}
