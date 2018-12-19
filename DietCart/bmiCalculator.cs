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
    public partial class bmiCalculator : UserControl
    {
        public bmiCalculator()
        {
            InitializeComponent();
        }
        

        private void submit_Click(object sender, EventArgs e)
        {
            dietInfo1.Visible = true;
        }

        private void bmiCalculator_Load(object sender, EventArgs e) {
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            newUser.Parent = pictureBox1;
            newUser.BackColor = Color.Transparent;
            gender.Parent = pictureBox1;
            gender.BackColor = Color.Transparent;
            male.Parent = pictureBox1;
            male.BackColor = Color.Transparent;
            female.Parent = pictureBox1;
            female.BackColor = Color.Transparent;
            feet.Parent = pictureBox1;
            feet.BackColor = Color.Transparent;
            inches.Parent = pictureBox1;
            inches.BackColor = Color.Transparent;
            height.Parent = pictureBox1;
            height.BackColor = Color.Transparent;
            weight.Parent = pictureBox1;
            weight.BackColor = Color.Transparent;
            age.Parent = pictureBox1;
            age.BackColor = Color.Transparent;


        }
        private void dietInfo1_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click_1(object sender, EventArgs e)
        {
            dietInfo1.Visible = true;
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            logup1.Visible = true;
        }
    }
}
