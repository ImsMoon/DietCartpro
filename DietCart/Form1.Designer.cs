﻿namespace DietCart
{
    partial class dietCart
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
            this.bmiCalculator1 = new DietCart.bmiCalculator();
            this.SuspendLayout();
            // 
            // bmiCalculator1
            // 
            this.bmiCalculator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmiCalculator1.Location = new System.Drawing.Point(0, 0);
            this.bmiCalculator1.Name = "bmiCalculator1";
            this.bmiCalculator1.Size = new System.Drawing.Size(1080, 710);
            this.bmiCalculator1.TabIndex = 0;
            // 
            // dietCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 710);
            this.Controls.Add(this.bmiCalculator1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "dietCart";
            this.Text = "Diet Cart";
            this.Load += new System.EventHandler(this.dietCart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private bmiCalculator bmiCalculator1;
    }
}

