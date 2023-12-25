namespace laba2_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Width = 90;
            label1.Height = 30;
            label1.Text = "f(x) = cos(x) + 0,25x - 0,5";
            label2.Text = "eps:";
            newton.Text = "";

            e_i.Text = "";
            e_i.Width = 70;
            e_i.Height = 50;

            e_i_2.Text = "";
            e_i_2.Width = 70;
            e_i_2.Height = 50;


            newton_2.Text = "";
            newton_2.Width = 70;
            newton_2.Height = 50;
            it1.Text = "";
            it2.Text = "";
            t1.Text = "";
            t2.Text = "";




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lab1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double eps = Convert.ToDouble(textBox1.Text);
            function_2_1 K = new function_2_1();
            double[] x_k = K.newton_method(eps);
            newton.Text = string.Format("x1:{0:f5}\nx2:{1:f5}\nx3:{2:f5}", x_k[0], x_k[1], x_k[2]);
            newton.Width = 70;
            newton.Height = 50;

            double[] x_k1 = K.easy_iteration(eps);

            int iter = K.it1;
            t1.Text = iter.ToString();
            int iter2 = K.it2;
            t2.Text = iter2.ToString();
            e_i.Text = string.Format("x1:{0:f5}\nx2:{1:f5}\nx3:{2:f5}", x_k1[0], x_k1[1], x_k1[2]);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double eps = Convert.ToDouble(textBox2.Text);
            function_2_2 K = new function_2_2();
            double[] x_k = K.newton(eps, 2);
            newton_2.Text = string.Format("x1:{0:f5}\nx2:{1:f5}\n", x_k[0], x_k[1]);



            double[] x_k1 = K.e_i(eps, 2);
            int iter = K.it1;
            it1.Text = iter.ToString();
            int iter2 = K.it2;
            it2.Text = iter2.ToString();
            e_i_2.Text = string.Format("x1:{0:f5}\nx2:{1:f5}", x_k1[0], x_k1[1]);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }
    }
}