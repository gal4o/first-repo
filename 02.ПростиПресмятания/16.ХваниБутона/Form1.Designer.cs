namespace _16.ХваниБутона
{
    partial class Form1
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
            this.buttonCatchMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCatchMe
            // 
            this.buttonCatchMe.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonCatchMe.FlatAppearance.BorderSize = 8;
            this.buttonCatchMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCatchMe.Location = new System.Drawing.Point(17, 22);
            this.buttonCatchMe.Name = "buttonCatchMe";
            this.buttonCatchMe.Size = new System.Drawing.Size(78, 86);
            this.buttonCatchMe.TabIndex = 0;
            this.buttonCatchMe.Text = "Catch Me";
            this.buttonCatchMe.UseVisualStyleBackColor = true;
            this.buttonCatchMe.Click += new System.EventHandler(this.buttonCatchMe_Click);
            this.buttonCatchMe.MouseCaptureChanged += new System.EventHandler(this.buttonCatchMe_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCatchMe);
            this.Name = "Form1";
            this.Text = "Catch the button";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCatchMe;
    }
}

