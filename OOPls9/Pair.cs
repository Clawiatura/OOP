using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPls9
{
    public class Pair
    {
        public double x { get; set; }
        public double y { get; set; }

        public void numb(double num1, double num2)
        {
            x = num1;
            y = num2;
        }
        public double proizv()
        {
            return x * y;

        }


        public class Rectagle : Pair
        {
            public double loong { get; set; }
            public double shoort { get; set; }

            public double sRestagle()
            {
                double res = loong * shoort;
                Console.WriteLine($"S = {res:F2}");
                return res;
            }
            public double pRestagle()
            {
                double res = 2 *(loong + shoort);
                Console.WriteLine($"P = {res:F2}");
                return res;
            }
        }
    }
}
