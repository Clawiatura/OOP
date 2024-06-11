using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//вычисления площади, периметра и точки пересечения медиан
namespace OOPls2
{
     class Maths
    {
        private int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public double P (double x)
        {
            double p = x * 3;
            return p;
            

        }
        public double S (double x)
        {
            double s = x * Math.Sqrt(3) / 6;
            return s;
        }
        public double mediana(double x)
        {
            double mediana = (1.0/2) * x;
            return mediana;
        }

    }
}
