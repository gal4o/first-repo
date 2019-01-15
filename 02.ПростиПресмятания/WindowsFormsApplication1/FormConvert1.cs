﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormConvert1 : Form
    {
        private void ConvertCurrency()
        {
            var amountBGN = this.numericUpDownAmount.Value;
            var amountEUR = amountBGN * 1.95583m;
            this.labelResult.Text =
              amountBGN + " BGN = " +
              Math.Round(amountEUR, 2) + " EUR";
        }

        public FormConvert1()
        {
            InitializeComponent();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void FormConvert1_Load(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDownAmount_ValueChanget(object sender, EventArgs e)
        {
            ConvertCurrency();
        }
    }
}
