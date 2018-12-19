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
    public partial class overWeightForm : Form
    {

        //private Rectangle button1Originalrec;
        //private Rectangle button2Originalrec;
        //private Rectangle button3Originalrec;
        //private Rectangle button4Originalrec;
        //private Rectangle button5Originalrec;
        //private Rectangle button6Originalrec;
        //private Rectangle cal1200Originalrec;
        //private Rectangle exerciseListOriginalrec;
        //private Rectangle pictureBox1Originalrec;
        //private Rectangle foodList1200Originalrec;
        //private Rectangle gmDietOriginalrec;
        //private Rectangle gmPanelOriginalrec;
        //private Rectangle militariDietOriginalrec;
        //private Rectangle militariPanelOriginalrec;
        //private Rectangle omadDietOriginalrec;
        //private Rectangle omadPanelOriginalrec;
        //private Rectangle panel1200calOriginalrec;

        private Size overWeightFormOriginalSize;

        public overWeightForm()
        {
            InitializeComponent();
        }

        private void overWeightForm_Load(object sender, EventArgs e)
        {
            overWeightFormOriginalSize = this.Size;

            //button3Originalrec = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            //button4Originalrec = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            //button1Originalrec = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            //button2Originalrec = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            //button5Originalrec = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            //button6Originalrec = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            //cal1200Originalrec = new Rectangle(cal1200.Location.X, cal1200.Location.Y, cal1200.Width, cal1200.Height);
            //exerciseListOriginalrec = new Rectangle(exerciseList.Location.X, exerciseList.Location.Y, exerciseList.Width, exerciseList.Height);
            //pictureBox1Originalrec = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
            //foodList1200Originalrec = new Rectangle(foodList1200.Location.X, foodList1200.Location.Y, foodList1200.Width, foodList1200.Height);
            //gmDietOriginalrec = new Rectangle(gmDiet.Location.X, gmDiet.Location.Y, gmDiet.Width, gmDiet.Height);
            //gmPanelOriginalrec = new Rectangle(gmPanel.Location.X, gmPanel.Location.Y, gmPanel.Width, gmPanel.Height);
            //militariDietOriginalrec = new Rectangle(militariDiet.Location.X, militariDiet.Location.Y, militariDiet.Width, militariDiet.Height);
            //militariPanelOriginalrec = new Rectangle(militariPanel.Location.X, militariPanel.Location.Y, militariPanel.Width, militariPanel.Height);
            //omadDietOriginalrec = new Rectangle(omadDiet.Location.X, omadDiet.Location.Y, omadDiet.Width, omadDiet.Height);
            //omadPanelOriginalrec = new Rectangle(omadPanel.Location.X, omadPanel.Location.Y, omadPanel.Width, omadPanel.Height);
            //panel1200calOriginalrec = new Rectangle(panel1200cal.Location.X, panel1200cal.Location.Y, panel1200cal.Width, panel1200cal.Height);

            //this.Resize += new System.EventHandler(this.overWeightForm_Resize);

        }

        private void reSizeChildrenControls()
        {

            //resizeControl(button3Originalrec, button3);
            //resizeControl(button1Originalrec, button1);
            //resizeControl(button4Originalrec, button4);
            //resizeControl(button3Originalrec, button3);
            //resizeControl(button2Originalrec, button2);
            //resizeControl(button5Originalrec, button5);
            //resizeControl(button6Originalrec, button6);
            //resizeControl(cal1200Originalrec, cal1200);
            //resizeControl(exerciseListOriginalrec, exerciseList);
            //resizeControl(pictureBox1Originalrec, pictureBox1);
            //resizeControl(foodList1200Originalrec, foodList1200);
            //resizeControl(gmDietOriginalrec, gmDiet);
            //resizeControl(gmPanelOriginalrec, gmPanel);
            //resizeControl(militariDietOriginalrec, militariDiet);
            //resizeControl(militariPanelOriginalrec, militariPanel);
            //resizeControl(omadDietOriginalrec, omadDiet);
            //resizeControl(omadPanelOriginalrec, omadPanel);
            //resizeControl(panel1200calOriginalrec, panel1200cal);




        }

        private void resizeControl(Rectangle originalControlRect, Control control)
        {

            //float xRatio = (float)(this.Width) / (float)(overWeightFormOriginalSize.Width);
            //float yRatio = (float)(this.Height) / (float)(overWeightFormOriginalSize.Height);

            //int newX = (int)(originalControlRect.X * xRatio);
            //int newY = (int)(originalControlRect.Y * yRatio);
            //int newWidth = (int)(originalControlRect.Width * xRatio);
            //int newHeight = (int)(originalControlRect.Height * yRatio);

            //control.Location = new Point(newX, newY);
            //control.Size = new Size(newWidth, newHeight);

        }

        private void overWeightForm_Resize(object sender, EventArgs e)
        {
            //reSizeChildrenControls();
        }
        private void cal1200_Click(object sender, EventArgs e)
        {
            panel1200cal.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gmDiet_Click(object sender, EventArgs e)
        {
            gmPanel.Visible = true;
        }

        private void omadDiet_Click(object sender, EventArgs e)
        {
            omadPanel.Visible = true;
        }

        private void militariDiet_Click(object sender, EventArgs e)
        {
            militariPanel.Visible = true;
        }

        private void foodList1200_Click(object sender, EventArgs e)
        {
            overDataGridUserControl1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            overDataGridUserControl1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            overDataGridUserControl1.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            overDataGridUserControl1.Visible = true;

        }
    }
}
