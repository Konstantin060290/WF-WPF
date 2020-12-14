using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoUr2
{
    public class Ur2
    {
        public static double a;
        public static double b;
        public static double c;
        public static double x1;
        public static double x2;
        public static double d;
        public static int dd;
       

        public static double Deskr(double a, double b, double c)
        {
            d = b * b - 4 * a * c;
            return d;

        }

        public  static int Gg(double a, double b, double c, out double x1, out double x2)
        {

            d = Deskr(a, b, c);

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return 1;
            }

            else
            {
                x1 = (-b + Math.Abs(d)) / (2 * a);
                x2 = x1;
                return 0;
            }


        }


     
    }
}
