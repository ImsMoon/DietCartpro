namespace DietCart
{
    partial class underOverNormal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.underWeight = new System.Windows.Forms.Button();
            this.normalWeight = new System.Windows.Forms.Button();
            this.overWeight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // underWeight
            // 
            this.underWeight.BackColor = System.Drawing.Color.LemonChiffon;
            this.underWeight.Dock = System.Windows.Forms.DockStyle.Left;
            this.underWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underWeight.Location = new System.Drawing.Point(0, 0);
            this.underWeight.Name = "underWeight";
            this.underWeight.Size = new System.Drawing.Size(374, 369);
            this.underWeight.TabIndex = 0;
            this.underWeight.Text = "UNDER WEIGHT";
            this.underWeight.UseVisualStyleBackColor = false;
            this.underWeight.Click += new System.EventHandler(this.underWeight_Click);
            // 
            // normalWeight
            // 
            this.normalWeight.BackColor = System.Drawing.Color.PaleGreen;
            this.normalWeight.Dock = System.Windows.Forms.DockStyle.Right;
            this.normalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalWeight.Location = new System.Drawing.Point(719, 0);
            this.normalWeight.Name = "normalWeight";
            this.normalWeight.Size = new System.Drawing.Size(355, 369);
            this.normalWeight.TabIndex = 1;
            this.normalWeight.Text = "NORMAL WEIGHT";
            this.normalWeight.UseVisualStyleBackColor = false;
            this.normalWeight.Click += new System.EventHandler(this.normalWeight_Click);
            // 
            // overWeight
            // 
            this.overWeight.BackColor = System.Drawing.Color.IndianRed;
            this.overWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.overWeight.ImageKey = "(none)";
            this.overWeight.Location = new System.Drawing.Point(374, 0);
            this.overWeight.Name = "overWeight";
            this.overWeight.Size = new System.Drawing.Size(345, 369);
            this.overWeight.TabIndex = 2;
            this.overWeight.Text = "OVER WEIGHT";
            this.overWeight.UseVisualStyleBackColor = false;
            this.overWeight.Click += new System.EventHandler(this.overWeight_Click);
            // 
            // underOverNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.overWeight);
            this.Controls.Add(this.normalWeight);
            this.Controls.Add(this.underWeight);
            this.Name = "underOverNormal";
            this.Size = new System.Drawing.Size(1074, 369);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button underWeight;
        private System.Windows.Forms.Button normalWeight;
        private System.Windows.Forms.Button overWeight;
    }
}
