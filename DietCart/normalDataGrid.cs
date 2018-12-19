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

    public partial class normalDataGrid : UserControl
    {
        UserDataControl ud = new UserDataControl();
        public normalDataGrid()
        {
            InitializeComponent();
        }

        private void normalDataGrid_Load(object sender, EventArgs e)
        {
            dataGridViewNormal.DataSource = ud.GetNormalFoodList();
            dataGridViewNormal.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
