using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPls9
{
    public class Luquid
    {
        public string name { get; set; }
        public double plotnost { get; set; }

        public void NewPlotnost(double newPlotnost)
        {
            plotnost = newPlotnost;
            Console.WriteLine($"NewPlotnost' = {plotnost}");
        }
         public class Alcohol : Luquid
        {
            public double plotnostSpirt;

            public void newPlotnostSpirt(double newPlotnostSpirt)
            {
                plotnostSpirt = newPlotnostSpirt;
                Console.WriteLine($"NewPlotnost' = {plotnostSpirt}");
            }
        }
    }
}