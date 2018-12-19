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
    public partial class dietInfo : UserControl
    {
       

        public dietInfo()
        {
            InitializeComponent();
        }
        private void dietInfo_Load(object sender, EventArgs e) {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

        }

        private void dietList_Click(object sender, EventArgs e)
        {
            underOverNormal1.Visible = true;
        }
    }
}
