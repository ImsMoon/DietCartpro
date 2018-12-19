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
    public partial class logup : UserControl
    {
        FoodData sd = new FoodData();
        public logup()
        {
            InitializeComponent();
        }

        

       

        
        

        private void logup_Load(object sender, EventArgs e)
        {
           

        }

        private void login_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dataGridView1.DataSource = sd.GetFoodList();
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            panel2add.Visible = true;
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
           // panel2Delete.Visible = true;
        }

        private void panel2add_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            
            FoodTable s = new FoodTable();
           //s.FoodId = int.Parse(FoodID.Text);
            s.FoodName = foodName.Text;
            s.FoodPrice = float.Parse(FoodPrice.Text);
            s.FoodQuantity = textBox5.Text;
            s.FoodStatus = comboBox1.Text;
            

            sd.Insert(s);
            dataGridView2.DataSource = sd.GetFoodList();
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
    }

