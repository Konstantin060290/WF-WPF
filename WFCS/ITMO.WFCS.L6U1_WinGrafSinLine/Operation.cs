using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.WFCS.L6U1_WinGrafSinLine
{
    class Operation
    {
        public static double SummSin(int x, double a, double b)
        {
            double res;
            return res = Math.Sin(x * a) + Math.Sin(x * b);
        }
    }
}
