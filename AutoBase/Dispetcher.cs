using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase
{
    public class Dispetcher:Voditel
    {
        public void distribute (string voditel, string car,string reis)
        {
            if (voditel == null)
            {
                Console.WriteLine("Свободных водителей нет");
            }
            else 
            {
                Console.WriteLine($"Водитель {voditel}  c машиной {car} назначен на рейс {reis} ");
            }
        }
        public void otstranit(string voditel,int ageDefolt)
        {
            int age = 65;
            if (ageDefolt > age )
            {
                Console.WriteLine("Водитель отстранен из-за возраста");
            }
        }
    }
    public class Reis
    {
        public string reis { get; set; }
    }
}

