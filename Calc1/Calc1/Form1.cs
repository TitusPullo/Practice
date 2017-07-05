using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc1.OneArg;
using Calc1.TwoArg;

namespace Calc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClickTwoArg(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);


            ICalculator calculator = CalculatesFactory.CreateCalculator(((Button) sender).Name);
            double result = calculator.Calculate(first, second);

            textBox3.Text = result.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClickOneArg(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);


            I2Calculator calculator = CalculatesFactoryTwo.CreateCalculator(((Button) sender).Name);
            double result = calculator.Calculate(first);

            textBox3.Text = result.ToString();
        }
    }
}
