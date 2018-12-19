namespace DietCart
{
    partial class normalWeightFrom
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
            this.normalPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.naturalPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.normalDiet = new System.Windows.Forms.Button();
            this.naturalDiet = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.normalDataGrid1 = new DietCart.normalDataGrid();
            this.normalPanel.SuspendLayout();
            this.naturalPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // normalPanel
            // 
            this.normalPanel.AutoSize = true;
            this.normalPanel.Controls.Add(this.button6);
            this.normalPanel.Controls.Add(this.button4);
            this.normalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalPanel.Location = new System.Drawing.Point(265, 43);
            this.normalPanel.Name = "normalPanel";
            this.normalPanel.Size = new System.Drawing.Size(256, 34);
            this.normalPanel.TabIndex = 1;
            this.normalPanel.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(138, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 31);
            this.button6.TabIndex = 3;
            this.button6.Text = "exercise list";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 31);
            this.button4.TabIndex = 2;
            this.button4.Text = "Food List";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // naturalPanel
            // 
            this.naturalPanel.AutoSize = true;
            this.naturalPanel.Controls.Add(this.button3);
            this.naturalPanel.Controls.Add(this.button5);
            this.naturalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naturalPanel.Location = new System.Drawing.Point(527, 43);
            this.naturalPanel.Name = "naturalPanel";
            this.naturalPanel.Size = new System.Drawing.Size(256, 34);
            this.naturalPanel.TabIndex = 2;
            this.naturalPanel.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(110, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "exercise list";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(3, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 34);
            this.button5.TabIndex = 1;
            this.button5.Text = "Food List";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // normalDiet
            // 
            this.normalDiet.AutoSize = true;
            this.normalDiet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.normalDiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.normalDiet.Location = new System.Drawing.Point(265, 3);
            this.normalDiet.Name = "normalDiet";
            this.normalDiet.Size = new System.Drawing.Size(256, 30);
            this.normalDiet.TabIndex = 3;
            this.normalDiet.Text = "Normal Diet";
            this.normalDiet.UseVisualStyleBackColor = false;
            this.normalDiet.Click += new System.EventHandler(this.normalDiet_Click);
            // 
            // naturalDiet
            // 
            this.naturalDiet.AutoSize = true;
            this.naturalDiet.BackColor = System.Drawing.SystemColors.Info;
            this.naturalDiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.naturalDiet.Location = new System.Drawing.Point(527, 3);
            this.naturalDiet.Name = "naturalDiet";
            this.naturalDiet.Size = new System.Drawing.Size(256, 30);
            this.naturalDiet.TabIndex = 4;
            this.naturalDiet.Text = "Natural Diet";
            this.naturalDiet.UseVisualStyleBackColor = false;
            this.naturalDiet.Click += new System.EventHandler(this.naturalDiet_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.normalPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.naturalPanel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.naturalDiet, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.normalDiet, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 80);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // normalDataGrid1
            // 
            this.normalDataGrid1.BackColor = System.Drawing.Color.Transparent;
            this.normalDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalDataGrid1.Location = new System.Drawing.Point(0, 80);
            this.normalDataGrid1.Name = "normalDataGrid1";
            this.normalDataGrid1.Size = new System.Drawing.Size(1048, 515);
            this.normalDataGrid1.TabIndex = 6;
            this.normalDataGrid1.Visible = false;
            // 
            // normalWeightFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DietCart.Properties.Resources.weight_loss_girl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 595);
            this.Controls.Add(this.normalDataGrid1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "normalWeightFrom";
            this.Text = "normalWeightFrom";
            this.Load += new System.EventHandler(this.normalWeightFrom_Load);
            this.normalPanel.ResumeLayout(false);
            this.naturalPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel normalPanel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel naturalPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button normalDiet;
        private System.Windows.Forms.Button naturalDiet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private normalDataGrid normalDataGrid1;
    }
}