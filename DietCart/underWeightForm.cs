using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCart
{
    public partial class underWeightForm : Form
    
    {

        public underWeightForm()
        {
            InitializeComponent();
        }

        
        

        

        



        private void protinDiet_Click(object sender, EventArgs e)
        {
            protinepanel.Visible = true;
        }

        private void highProtinDiet_Click(object sender, EventArgs e)
        {
            highProtinePanel.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            underDataGridUserControl1.Visible = true;
        }

        private void foodList_Click(object sender, EventArgs e)
        {
            underDataGridUserControl1.Visible = true;
        }
    }
}
