namespace laba2_final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            t1 = new Label();
            tabControl1 = new TabControl();
            Lab1 = new TabPage();
            t2 = new Label();
            e_i = new Label();
            newton = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Lab2 = new TabPage();
            it2 = new Label();
            it1 = new Label();
            newton_2 = new Label();
            label8 = new Label();
            e_i_2 = new Label();
            label6 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            eps = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            Lab1.SuspendLayout();
            Lab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // t1
            // 
            t1.AutoSize = true;
            t1.Location = new Point(14, 225);
            t1.Name = "t1";
            t1.Size = new Size(50, 20);
            t1.TabIndex = 8;
            t1.Text = "label5";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Lab1);
            tabControl1.Controls.Add(Lab2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(378, 299);
            tabControl1.TabIndex = 0;
            // 
            // Lab1
            // 
            Lab1.Controls.Add(t2);
            Lab1.Controls.Add(t1);
            Lab1.Controls.Add(e_i);
            Lab1.Controls.Add(newton);
            Lab1.Controls.Add(label4);
            Lab1.Controls.Add(label3);
            Lab1.Controls.Add(button1);
            Lab1.Controls.Add(textBox1);
            Lab1.Controls.Add(label2);
            Lab1.Controls.Add(label1);
            Lab1.Location = new Point(4, 29);
            Lab1.Name = "Lab1";
            Lab1.Padding = new Padding(3);
            Lab1.Size = new Size(370, 266);
            Lab1.TabIndex = 0;
            Lab1.Text = "Lab2.1";
            Lab1.UseVisualStyleBackColor = true;
            Lab1.Click += Lab1_Click;
            // 
            // t2
            // 
            t2.AutoSize = true;
            t2.Location = new Point(185, 225);
            t2.Name = "t2";
            t2.Size = new Size(50, 20);
            t2.TabIndex = 9;
            t2.Text = "label6";
            // 
            // e_i
            // 
            e_i.AutoSize = true;
            e_i.Location = new Point(185, 151);
            e_i.Name = "e_i";
            e_i.Size = new Size(50, 20);
            e_i.TabIndex = 7;
            e_i.Text = "label6";
            e_i.Click += label6_Click;
            // 
            // newton
            // 
            newton.AutoSize = true;
            newton.Location = new Point(14, 151);
            newton.Name = "newton";
            newton.Size = new Size(50, 20);
            newton.TabIndex = 6;
            newton.Text = "label5";
            newton.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 120);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 5;
            label4.Text = "Простые итерации";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 120);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 4;
            label3.Text = "Метод Ньютона";
            // 
            // button1
            // 
            button1.Location = new Point(230, 47);
            button1.Name = "button1";
            button1.Size = new Size(99, 29);
            button1.TabIndex = 3;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 51);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(68, 29);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Lab2
            // 
            Lab2.Controls.Add(it2);
            Lab2.Controls.Add(it1);
            Lab2.Controls.Add(newton_2);
            Lab2.Controls.Add(label8);
            Lab2.Controls.Add(e_i_2);
            Lab2.Controls.Add(label6);
            Lab2.Controls.Add(button2);
            Lab2.Controls.Add(textBox2);
            Lab2.Controls.Add(eps);
            Lab2.Controls.Add(pictureBox1);
            Lab2.Location = new Point(4, 29);
            Lab2.Name = "Lab2";
            Lab2.Padding = new Padding(3);
            Lab2.Size = new Size(370, 266);
            Lab2.TabIndex = 1;
            Lab2.Text = "Lab2.2";
            Lab2.UseVisualStyleBackColor = true;
            // 
            // it2
            // 
            it2.AutoSize = true;
            it2.Location = new Point(184, 227);
            it2.Name = "it2";
            it2.Size = new Size(50, 20);
            it2.TabIndex = 12;
            it2.Text = "label7";
            // 
            // it1
            // 
            it1.AutoSize = true;
            it1.Location = new Point(30, 227);
            it1.Name = "it1";
            it1.Size = new Size(50, 20);
            it1.TabIndex = 11;
            it1.Text = "label5";
            it1.Click += label5_Click_2;
            // 
            // newton_2
            // 
            newton_2.AutoSize = true;
            newton_2.Location = new Point(30, 173);
            newton_2.Name = "newton_2";
            newton_2.Size = new Size(50, 20);
            newton_2.TabIndex = 10;
            newton_2.Text = "label5";
            newton_2.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(184, 144);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 9;
            label8.Text = "Простые итерации";
            // 
            // e_i_2
            // 
            e_i_2.AutoSize = true;
            e_i_2.Location = new Point(184, 173);
            e_i_2.Name = "e_i_2";
            e_i_2.Size = new Size(50, 20);
            e_i_2.TabIndex = 8;
            e_i_2.Text = "label6";
            e_i_2.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 144);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 5;
            label6.Text = "Метод Ньютона";
            // 
            // button2
            // 
            button2.Location = new Point(226, 102);
            button2.Name = "button2";
            button2.Size = new Size(99, 29);
            button2.TabIndex = 4;
            button2.Text = "Выполнить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // eps
            // 
            eps.AutoSize = true;
            eps.Location = new Point(25, 102);
            eps.Name = "eps";
            eps.Size = new Size(32, 20);
            eps.TabIndex = 2;
            eps.Text = "eps";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.AaJtYbArZG0;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 300);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Lab1.ResumeLayout(false);
            Lab1.PerformLayout();
            Lab2.ResumeLayout(false);
            Lab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Lab1;
        private TabPage Lab2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        public Label e_i;
        public Label newton;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        public Label newton_2;
        private Label label8;
        public Label e_i_2;
        private Label label6;
        private Button button2;
        private TextBox textBox2;
        private Label eps;
        private Label it2;
        private Label it1;
        public Label t2;
        private Label t1;
    }
}