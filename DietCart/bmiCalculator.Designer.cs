namespace DietCart
{
    partial class bmiCalculator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bmiCalculator));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.newUser = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.inches = new System.Windows.Forms.Label();
            this.feet = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.dietInfo1 = new DietCart.dietInfo();
            this.logup1 = new DietCart.logup();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1073, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(752, 102);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(75, 38);
            this.logIn.TabIndex = 68;
            this.logIn.Text = "Log In ";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Admin Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(81, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Necessary for calculation";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(94, 437);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(169, 36);
            this.submit.TabIndex = 52;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click_1);
            // 
            // newUser
            // 
            this.newUser.AutoSize = true;
            this.newUser.BackColor = System.Drawing.Color.Transparent;
            this.newUser.Location = new System.Drawing.Point(521, 24);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(78, 20);
            this.newUser.TabIndex = 63;
            this.newUser.Text = "New User";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(191, 372);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 65;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(191, 296);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 64;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(353, 246);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(41, 26);
            this.textBox4.TabIndex = 62;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 26);
            this.textBox3.TabIndex = 61;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(348, 158);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(87, 24);
            this.female.TabIndex = 60;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.BackColor = System.Drawing.Color.Transparent;
            this.male.Location = new System.Drawing.Point(223, 156);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(68, 24);
            this.male.TabIndex = 59;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = false;
            // 
            // inches
            // 
            this.inches.AutoSize = true;
            this.inches.Location = new System.Drawing.Point(400, 249);
            this.inches.Name = "inches";
            this.inches.Size = new System.Drawing.Size(57, 20);
            this.inches.TabIndex = 58;
            this.inches.Text = "Inches";
            // 
            // feet
            // 
            this.feet.AutoSize = true;
            this.feet.Location = new System.Drawing.Point(269, 249);
            this.feet.Name = "feet";
            this.feet.Size = new System.Drawing.Size(42, 20);
            this.feet.TabIndex = 57;
            this.feet.Text = "Feet";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(92, 252);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(67, 20);
            this.weight.TabIndex = 56;
            this.weight.Text = "Weight :";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(92, 302);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(64, 20);
            this.height.TabIndex = 55;
            this.height.Text = "Height :";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(92, 375);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(46, 20);
            this.age.TabIndex = 54;
            this.age.Text = "Age :";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.Location = new System.Drawing.Point(92, 158);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(71, 20);
            this.gender.TabIndex = 53;
            this.gender.Text = "Gender :";
            // 
            // dietInfo1
            // 
            this.dietInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dietInfo1.Location = new System.Drawing.Point(0, 0);
            this.dietInfo1.Name = "dietInfo1";
            this.dietInfo1.Size = new System.Drawing.Size(1073, 611);
            this.dietInfo1.TabIndex = 69;
            this.dietInfo1.Visible = false;
            // 
            // logup1
            // 
            this.logup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logup1.Location = new System.Drawing.Point(0, 0);
            this.logup1.Name = "logup1";
            this.logup1.Size = new System.Drawing.Size(1073, 611);
            this.logup1.TabIndex = 70;
            this.logup1.Visible = false;
            // 
            // bmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logup1);
            this.Controls.Add(this.dietInfo1);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.inches);
            this.Controls.Add(this.feet);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.age);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.pictureBox1);
            this.Name = "bmiCalculator";
            this.Size = new System.Drawing.Size(1073, 611);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label newUser;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label inches;
        private System.Windows.Forms.Label feet;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label gender;
        private dietInfo dietInfo1;
        private logup logup1;
    }
}
