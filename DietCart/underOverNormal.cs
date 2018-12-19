using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCart
{
    public partial class underOverNormal : UserControl
    {
        public underOverNormal()
        {
            InitializeComponent();
        }

        private void overWeight_Click(object sender, EventArgs e)
        {
            overWeightForm uwf = new overWeightForm();
            uwf.Show();
        }

        private void normalWeight_Click(object sender, EventArgs e)
        {
            normalWeightFrom nwf = new normalWeightFrom();
            nwf.Show();
        }

        private void underWeight_Click(object sender, EventArgs e)
        {
            underWeightForm uwf = new underWeightForm();
            uwf.Show();
        }
    }
}
