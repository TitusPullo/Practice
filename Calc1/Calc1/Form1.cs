﻿using System;
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
           
            
            ICalculator calculator = CalculatesFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(first, second);

            textBox3.Text = result.ToString();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
