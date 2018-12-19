namespace DietCart
{
    partial class underWeightForm
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
            this.protinepanel = new System.Windows.Forms.Panel();
            this.others = new System.Windows.Forms.Button();
            this.foodList = new System.Windows.Forms.Button();
            this.highProtinePanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.protinDiet = new System.Windows.Forms.Button();
            this.highProtinDiet = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.underDataGridUserControl1 = new DietCart.underDataGridUserControl();
            this.protinepanel.SuspendLayout();
            this.highProtinePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // protinepanel
            // 
            this.protinepanel.Controls.Add(this.others);
            this.protinepanel.Controls.Add(this.foodList);
            this.protinepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.protinepanel.Location = new System.Drawing.Point(603, 52);
            this.protinepanel.Name = "protinepanel";
            this.protinepanel.Size = new System.Drawing.Size(294, 43);
            this.protinepanel.TabIndex = 1;
            this.protinepanel.Visible = false;
            // 
            // others
            // 
            this.others.BackColor = System.Drawing.Color.LightBlue;
            this.others.Location = new System.Drawing.Point(130, 2);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(130, 38);
            this.others.TabIndex = 1;
            this.others.Text = "Others";
            this.others.UseVisualStyleBackColor = false;
            // 
            // foodList
            // 
            this.foodList.BackColor = System.Drawing.Color.LightBlue;
            this.foodList.Location = new System.Drawing.Point(3, 3);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(121, 38);
            this.foodList.TabIndex = 0;
            this.foodList.Text = "Food List";
            this.foodList.UseVisualStyleBackColor = false;
            this.foodList.Click += new System.EventHandler(this.foodList_Click);
            // 
            // highProtinePanel
            // 
            this.highProtinePanel.Controls.Add(this.button4);
            this.highProtinePanel.Controls.Add(this.button3);
            this.highProtinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highProtinePanel.Location = new System.Drawing.Point(303, 52);
            this.highProtinePanel.Name = "highProtinePanel";
            this.highProtinePanel.Size = new System.Drawing.Size(294, 43);
            this.highProtinePanel.TabIndex = 2;
            this.highProtinePanel.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Location = new System.Drawing.Point(153, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "Others";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Food List";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // protinDiet
            // 
            this.protinDiet.BackColor = System.Drawing.Color.LightBlue;
            this.protinDiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.protinDiet.Location = new System.Drawing.Point(603, 3);
            this.protinDiet.Name = "protinDiet";
            this.protinDiet.Size = new System.Drawing.Size(294, 31);
            this.protinDiet.TabIndex = 0;
            this.protinDiet.Text = "Protin Diet";
            this.protinDiet.UseVisualStyleBackColor = false;
            this.protinDiet.Click += new System.EventHandler(this.protinDiet_Click);
            // 
            // highProtinDiet
            // 
            this.highProtinDiet.BackColor = System.Drawing.Color.LightSteelBlue;
            this.highProtinDiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.highProtinDiet.Location = new System.Drawing.Point(303, 3);
            this.highProtinDiet.Name = "highProtinDiet";
            this.highProtinDiet.Size = new System.Drawing.Size(294, 31);
            this.highProtinDiet.TabIndex = 3;
            this.highProtinDiet.Text = "High Protin Diet";
            this.highProtinDiet.UseVisualStyleBackColor = false;
            this.highProtinDiet.Click += new System.EventHandler(this.highProtinDiet_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.highProtinePanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.highProtinDiet, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.protinepanel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.protinDiet, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 98);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // underDataGridUserControl1
            // 
            this.underDataGridUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.underDataGridUserControl1.Location = new System.Drawing.Point(0, 98);
            this.underDataGridUserControl1.Name = "underDataGridUserControl1";
            this.underDataGridUserControl1.Size = new System.Drawing.Size(1200, 569);
            this.underDataGridUserControl1.TabIndex = 5;
            this.underDataGridUserControl1.Visible = false;
            // 
            // underWeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DietCart.Properties.Resources.wimp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 667);
            this.Controls.Add(this.underDataGridUserControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "underWeightForm";
            this.Text = "underWeightForm";
            this.protinepanel.ResumeLayout(false);
            this.highProtinePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel protinepanel;
        private System.Windows.Forms.Button others;
        private System.Windows.Forms.Button foodList;
        private System.Windows.Forms.Panel highProtinePanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button protinDiet;
        private System.Windows.Forms.Button highProtinDiet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private underDataGridUserControl underDataGridUserControl1;
    }
}