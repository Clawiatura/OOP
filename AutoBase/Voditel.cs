using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase
{
    public class Voditel : Car
    {
        public string name { get; set; }
        public int ageVoditel { get; set; }
        public void RepairCar()
        {
            techCar = 100;
            Console.WriteLine("Ремонт выполнен. Состояние машины 100/100");
        }
        public void reisVupolnen ()
        {
            Random random = new Random();
            techCar = random.Next(0,100);
            
            Console.WriteLine($"Рейс выполнен, состояние автомобиля = {techCar}/100");

        }
    }
}
