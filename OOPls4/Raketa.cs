using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPls4
{
    internal class Rocket
    {
        
        private string feel;
        private double valume;
        private double speed;
        private double distance;
        private double TimeSpentOnEachFoot;



        public Rocket(string v1, double v2, double v3, double v4)
        {
            this.feel = v1;
            this.valume = v2;
            this.speed = v3;
            this.distance = v4;
        }

        public void speedRocket(double time)
        {
            double speedRocket = distance / time;
            Console.WriteLine($"Скорость ракеты {speedRocket}");

        }
        public void Orbit()
        {
            
            double time = distance /speed;
            Console.WriteLine($"Времени до выхода на орбиту:{time}" );
        }
        public void stageD(double time)
        {
            TimeSpentOnEachFoot = time;
            if(TimeSpentOnEachFoot > 30 )
            {
                Console.WriteLine("Работает первая ступень");
            }
            else if (TimeSpentOnEachFoot >60)
            {
                Console.WriteLine("Работает вторая ступень");
            }
            else if(TimeSpentOnEachFoot > 61 && TimeSpentOnEachFoot <= 600)
            {
                Console.WriteLine("Работает третья ступень");
            }
            else Console.WriteLine("Все ступени уже отключились, орбитальный полет");
        }

    }
}
