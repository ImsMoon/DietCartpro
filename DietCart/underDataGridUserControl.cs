using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietCart.DataAccess;
using DietCart.Entity;
using System.Windows.Forms;

namespace DietCart
{
    public partial class underDataGridUserControl : UserControl
    {
        UserDataControl ud = new UserDataControl();
        public underDataGridUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void underDataGridUserControl_Load(object sender, EventArgs e)
        {
            dataGridViewUnder.DataSource = ud.GetUnderFoodList();
            dataGridViewUnder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
