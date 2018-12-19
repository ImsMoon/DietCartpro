namespace DietCart
{
    partial class normalDataGrid
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Bucket = new System.Windows.Forms.Label();
            this.dataGridViewBucket = new System.Windows.Forms.DataGridView();
            this.buy = new System.Windows.Forms.Button();
            this.dataGridViewNormal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.purchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBucket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.purchase);
            this.splitContainer1.Panel1.Controls.Add(this.Bucket);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewBucket);
            this.splitContainer1.Panel1.Controls.Add(this.buy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewNormal);
            this.splitContainer1.Size = new System.Drawing.Size(1229, 618);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 2;
            // 
            // Bucket
            // 
            this.Bucket.AutoSize = true;
            this.Bucket.Location = new System.Drawing.Point(13, 90);
            this.Bucket.Name = "Bucket";
            this.Bucket.Size = new System.Drawing.Size(59, 20);
            this.Bucket.TabIndex = 2;
            this.Bucket.Text = "Bucket";
            // 
            // dataGridViewBucket
            // 
            this.dataGridViewBucket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBucket.Location = new System.Drawing.Point(3, 126);
            this.dataGridViewBucket.Name = "dataGridViewBucket";
            this.dataGridViewBucket.RowTemplate.Height = 28;
            this.dataGridViewBucket.Size = new System.Drawing.Size(401, 210);
            this.dataGridViewBucket.TabIndex = 1;
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(33, 22);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(250, 40);
            this.buy.TabIndex = 0;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNormal
            // 
            this.dataGridViewNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNormal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNormal.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewNormal.Name = "dataGridViewNormal";
            this.dataGridViewNormal.RowTemplate.Height = 28;
            this.dataGridViewNormal.Size = new System.Drawing.Size(816, 618);
            this.dataGridViewNormal.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // purchase
            // 
            this.purchase.Location = new System.Drawing.Point(33, 396);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(108, 39);
            this.purchase.TabIndex = 5;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = true;
            // 
            // normalDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "normalDataGrid";
            this.Size = new System.Drawing.Size(1229, 618);
            this.Load += new System.EventHandler(this.normalDataGrid_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBucket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label Bucket;
        private System.Windows.Forms.DataGridView dataGridViewBucket;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.DataGridView dataGridViewNormal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button purchase;
    }
}
