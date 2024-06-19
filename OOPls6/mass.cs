using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPls6
{
    internal class Mass
    {
        private List<int> mas;

        public Mass(int n)
        {
            this.mas = new List<int>(n);
        }
        public static double Avg (int[] n) 
        {
            double res = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int sum = 0;
                sum += n[i];
                res = sum/n.Length;
                
            }
            return res;
            

        }
       public  static void Main(int[] massiv)
        {
            double averege = Avg(massiv);

            Console.WriteLine(averege);
        }
    }
}
