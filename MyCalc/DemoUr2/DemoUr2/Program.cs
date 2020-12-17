using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoUr2
{
   public class Program:Ur2
    {
       
        //public static double a;
        //public static double b;
        //public static double c;
        //public static double x1;
        //public static double x2;
        //public static int dd;

        static void Main(string[] args)
        {

            if (Ur2.Deskr(a, b, c) >= 0)
            {
                dd = Ur2.Gg(a, b, c, out x1, out x2);

            }
            else
            {
                dd = -1;
            }

           
        }
    }
}





