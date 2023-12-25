
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_final
{
    //лаба 2.1
    internal class function_2_1
    {
        public int it1 = 0;
        public int it2 = 0;
        double my_function(double x)
        {
            return Math.Cos(x) + 0.25 * x - 0.5;
        }


        double derivative_1(double x) //1 производная
        {
            return -Math.Sin(x) + 0.25;
        }

        double derivative_2(double x) //2 производная
        {
            return -Math.Cos(x);
        }

        double find_root(double x_0, double eps)
        {
            double p_x_k = x_0;
            double x_k = p_x_k - my_function(p_x_k) / derivative_1(p_x_k);
            while (Math.Abs(x_k - p_x_k) > eps)
            {
                it1++;
                p_x_k = x_k;
                x_k = p_x_k - my_function(p_x_k) / derivative_1(p_x_k);
            }
            return x_k;
        }

        
        public double[] newton_method(double eps)//реализация метода Ньютона
        {

            double[] x_k = new double[3];
            double[] x_0 = new double[3];
            double[,] intervals = new double[3, 2];

            intervals[0, 0] = -1; intervals[0, 1] = 0;
            x_0[0] = -1;
            x_k[0] = find_root(x_0[0], eps);

            intervals[1, 0] = 1; intervals[1, 1] = 2;
            x_0[1] = 1.5;
            x_k[1] = find_root(x_0[1], eps);


            intervals[2, 0] = 4; intervals[2, 1] = 5;
            x_0[2] = 4.5;
            x_k[2] = find_root(x_0[2], eps);
            return x_k;
            

        }
        double find_root_2(double x_0, double eps, double q, Func<double, double> phi)
        {
            double p_x_k = x_0;
            double x_k = phi(p_x_k);
            while ((q/(1-q))*Math.Abs(x_k - p_x_k) > eps)
            {
                it2++;
                p_x_k = x_k;
                x_k = phi(p_x_k);
            }
            return x_k;
        }

        double phi_1(double x)
        {
            return Math.Acos(-0.25 * x + 0.5);
        }

        double phi_2(double x)
        {
            return -Math.Acos(-0.25*x+0.5);
        }

        double phi_2pi(double x)
        {
            return -Math.Acos(-0.25 * x + 0.5)+2*Math.PI;
        }

        
        public double[] easy_iteration(double eps)//реализация метода простых итераций
        {
            double[] x_k = new double[3];
            double[] x_0 = new double[3];
            double q = 0.5;
            double[,] intervals = new double[3, 2];

            intervals[0, 0] = -0.81; intervals[0, 1] = -0.77;
            x_0[0] = -0.81;
            x_k[0] = find_root_2(x_0[0], eps, q, phi_2);
            

            intervals[1, 0] = 1.4; intervals[1, 1] = 1.44;
            x_0[1] = 1.4;
            x_k[1] = find_root_2(x_0[1], eps, q, phi_1);


            intervals[2, 0] = 4.1; intervals[2, 1] = 4.2;
            x_0[2] = 4.1;
            x_k[2] = find_root_2(x_0[2],eps,q, phi_2pi);
            return x_k;

        }


    }


    //лаба 2.2
    internal class function_2_2
    {
        MAT m = new MAT();
        public int it1 = 0;
        public int it2 = 0;
        public double f_1(double x1, double x2, double a)
        {
            return x1 - Math.Cos(x2) - 1;
        }

        public double f_2(double x1, double x2, double a)
        {
            return x2 - Math.Log(x1 + 1, 10) - a;
        }

        public double f_1_x1(double x1, double x2, double a)
        {
            return 1;
        }

        public double f_1_x2(double x1, double x2, double a)
        {
            return Math.Sin(x2);
        }

        public double f_2_x1(double x1, double x2, double a)
        {
            return -1 / ((x1 + 1) * Math.Log(10));
        }
        
        public double f_2_x2(double x1, double x2, double a)
        {
            return 1;
        }

       
        public double[] newton(double eps, double a) //реализация метода Ньютона
        {
            double[] x_p = new double[2];
            double[] x_k = new double[2];
            x_k[0] = 0.2; x_k[1] = 2;
            double[] x_kk = new double[2];
          //  Func<double, double, double, double>[,] A1 = new Func<double, double, double , double>[2, 2];
          //  Func<double, double, double, double>[,] A2 = new Func<double, double, double, double>[2, 2];
          //  Func<double, double, double, double>[,] J = new Func<double, double, double, double>[2, 2];
            double[,] A1 = new double[2, 2];
            double[,] A2 = new double[2, 2];
            double[,] J = new double[2, 2];

            //  A1[0, 0] = f_1; A1[0, 1] = f_1_x2; A1[1, 0] = f_2; A1[1,1] = f_2_x2;
            //  A2[0, 1] = f_1; A2[0, 0] = f_1_x1; A2[1, 1] = f_2; A2[1, 0] = f_2_x1;

            //  J[0, 0] = f_1_x1; J[0, 1] = f_1_x2; J[1, 0] = f_2_x1; J[1, 1] = f_2_x2;

            do
            {
                it1++;

                A1[0, 0] = f_1(x_k[0], x_k[1], a); A1[0, 1] = f_1_x2(x_k[0], x_k[1], a);
                A1[1, 0] = f_2(x_k[0], x_k[1], a); A1[1, 1] = f_2_x2(x_k[0], x_k[1], a);

                A2[0, 0] = f_1_x1(x_k[0], x_k[1], a); A2[0, 1] = f_1(x_k[0], x_k[1], a);
                A2[1, 0] = f_2_x1(x_k[0], x_k[1], a); A2[1, 1] = f_2(x_k[0], x_k[1], a);

                J[0, 0] = f_1_x1(x_k[0], x_k[1], a); J[0, 1] = f_1_x2(x_k[0], x_k[1], a);
                J[1, 0] = f_2_x1(x_k[0], x_k[1], a); J[1, 1] = f_2_x2(x_k[0], x_k[1], a);

                x_kk[0] = x_k[0] - m.Det(A1, 2) / m.Det(J, 2);
                x_kk[1] = x_k[1] - m.Det(A2, 2) / m.Det(J, 2);

                x_p[0] = x_k[0]; x_p[1] = x_k[1];
                x_k[0] = x_kk[0]; x_k[1] = x_kk[1];


            } while ((Math.Sqrt(Math.Pow(x_p[0] - x_kk[0], 2) + Math.Pow(x_p[1] - x_kk[1], 2))) > eps);

            return x_kk;

        }

        public double phi_f1(double x1, double x2, double a)
        {
            return Math.Cos(x2) + 1;
        }

        public double phi_f2(double x1, double x2, double a)
        {
            return a + Math.Log(x1 + 1, 10);
        } 


      
        public double[] e_i(double eps, double a)  //реализация метода простых итераций
        {
            double q = 0.5;
            double[] x_k = new double[2];
            double[] x_kk = new double[2];
            double[] x_p = new double[2];
            x_k[0] = 0.2; x_k[1] = 2;
            do
            {
                it2++;
                x_kk[0] = phi_f1(x_k[0], x_k[1], a);
                x_kk[1] = phi_f2(x_k[0], x_k[1], a);

                x_p[0] = x_k[0]; x_p[1] = x_k[1];
                x_k[0] = x_kk[0]; x_k[1] = x_kk[1];

                

            } while (q / (1 - q) * Norm(x_p, x_kk) > eps);
            return x_kk;
        }

        double Norm(double[] x_k, double[] x_kk)
        {
            double max = 0;
            for (int i = 0; i < 2; i++)
            {
                if (Math.Abs(x_k[i] - x_kk[i]) > max) max = Math.Abs(x_k[i] - x_kk[i]);

            }

            return max;
        }

    }

}
