﻿namespace _17.Currency_Converter
{
	partial class FormConverter
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
			this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDownAmount
			// 
			this.numericUpDownAmount.DecimalPlaces = 2;
			this.numericUpDownAmount.Location = new System.Drawing.Point(13, 14);
			this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numericUpDownAmount.Name = "numericUpDownAmount";
			this.numericUpDownAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.numericUpDownAmount.Size = new System.Drawing.Size(180, 26);
			this.numericUpDownAmount.TabIndex = 0;
			this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount);
			// 
			// comboBoxCurrency
			// 
			this.comboBoxCurrency.BackColor = System.Drawing.SystemColors.MenuBar;
			this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCurrency.FormattingEnabled = true;
			this.comboBoxCurrency.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
			this.comboBoxCurrency.Location = new System.Drawing.Point(364, 15);
			this.comboBoxCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxCurrency.Name = "comboBoxCurrency";
			this.comboBoxCurrency.Size = new System.Drawing.Size(180, 28);
			this.comboBoxCurrency.TabIndex = 1;
			this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
			this.comboBoxCurrency.StyleChanged += new System.EventHandler(this.comboBoxCurrency_StyleChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(242, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "BGN   ->";
			// 
			// labelResult
			// 
			this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelResult.Location = new System.Drawing.Point(167, 81);
			this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(219, 26);
			this.labelResult.TabIndex = 3;
			this.labelResult.Text = "label2";
			this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
			// 
			// FormConverter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 168);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxCurrency);
			this.Controls.Add(this.numericUpDownAmount);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormConverter";
			this.Text = "Currency Converter";
			this.Load += new System.EventHandler(this.FormConvert_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDownAmount;
		private System.Windows.Forms.ComboBox comboBoxCurrency;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelResult;
	}
}

