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
    public partial class overDataGridUserControl : UserControl
    {
        UserDataControl ud = new UserDataControl();
        public overDataGridUserControl()
        {
            InitializeComponent();
        }

        private void overDataGridUserControl_Load(object sender, EventArgs e)
        {

            dataGridViewUnder.DataSource = ud.GetOverFoodList();
            dataGridViewUnder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
