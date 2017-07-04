using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);
            double result = Convert.ToDouble(textBox3.Text);
            switch (((Button)sender).Name)
            {
                case "button1":
                    result = first + second;
                    //выполнение операции
                    break;
                case "button2":
                    result = first - second;
                    //выполнение операции
                    break;
                case "button3":
                    result = first * second;
                    //выполнение операции
                    break;
                case "button4":
                    result = first / second;
                    //выполнение операции
                    break;
                default:
                    throw new Exception("");
            }

            textBox3.Text = result.ToString();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
