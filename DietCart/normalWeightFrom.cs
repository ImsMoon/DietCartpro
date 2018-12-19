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
    public partial class normalWeightFrom : Form
    {

        UserDataControl ud = new UserDataControl();

        //private Rectangle button3Originalrec;
        //private Rectangle button4Originalrec;
        //private Rectangle button5Originalrec;
        //private Rectangle button6Originalrec;
        //private Rectangle naturalDietOriginalrec;
        //private Rectangle naturalPanelOriginalrec;
        //private Rectangle normalDietOriginalrec;
        //private Rectangle normalPanelOriginalrec;
        //private Rectangle pictureBox1Originalrec;

        //private Size normalWeightFromOriginalSize;
        public normalWeightFrom()
        {
            InitializeComponent();
        }

        private void normalWeightFrom_Load(object sender, EventArgs e)
        {
            //normalWeightFromOriginalSize = this.Size;

            //button3Originalrec = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            //button4Originalrec = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            //button5Originalrec = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            //button6Originalrec = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            //naturalDietOriginalrec = new Rectangle(naturalDiet.Location.X, naturalDiet.Location.Y, naturalDiet.Width, naturalDiet.Height);
            //naturalPanelOriginalrec = new Rectangle(naturalPanel.Location.X, naturalPanel.Location.Y, naturalPanel.Width, naturalPanel.Height);
            //normalDietOriginalrec = new Rectangle(normalDiet.Location.X, normalDiet.Location.Y, normalDiet.Width, normalDiet.Height);
            //normalPanelOriginalrec = new Rectangle(normalPanel.Location.X, normalPanel.Location.Y, normalPanel.Width, normalPanel.Height);
            //pictureBox1Originalrec = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);

            //this.Resize += new System.EventHandler(this.normalWeightFrom_Resize);

        }

        private void reSizeChildrenControls()
        {

            //resizeControl(button3Originalrec, button3);
            //resizeControl(button4Originalrec, button4);
            //resizeControl(button5Originalrec, button5);
            //resizeControl(button6Originalrec, button6);
            //resizeControl(naturalDietOriginalrec, naturalDiet);
            //resizeControl(naturalPanelOriginalrec, naturalPanel);
            //resizeControl(normalDietOriginalrec, normalDiet);
            //resizeControl(normalPanelOriginalrec, normalPanel);
            //resizeControl(pictureBox1Originalrec, pictureBox1);



        }

        private void resizeControl(Rectangle originalControlRect, Control control)
        {

            //float xRatio = (float)(this.Width) / (float)(normalWeightFromOriginalSize.Width);
            //float yRatio = (float)(this.Height) / (float)(normalWeightFromOriginalSize.Height);

            //int newX = (int)(originalControlRect.X * xRatio);
            //int newY = (int)(originalControlRect.Y * yRatio);
            //int newWidth = (int)(originalControlRect.Width * xRatio);
            //int newHeight = (int)(originalControlRect.Height * yRatio);

            //control.Location = new Point(newX, newY);
            //control.Size = new Size(newWidth, newHeight);

        }

        private void normalWeightFrom_Resize(object sender, EventArgs e)
        {
            //reSizeChildrenControls();


        }
        private void normalDiet_Click(object sender, EventArgs e)
        {
            normalPanel.Visible = true;
        }

        private void naturalDiet_Click(object sender, EventArgs e)
        {
            naturalPanel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            normalDataGrid1.Visible = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            normalDataGrid1.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
