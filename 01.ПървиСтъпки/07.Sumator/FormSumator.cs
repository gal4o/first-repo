﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07.Sumator
{
    public partial class FormSumator : Form
    {
        public FormSumator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = double.Parse(this.textBox1.Text);
                var num2 = double.Parse(this.textBox2.Text);
                var sum = num1 + num2;
                textBoxSum.Text = sum.ToString();
            }
            catch
            {
                textBoxSum.Text = "error";
            }
        }
    }
}
