using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстракнные_классы
{
    internal class Herbivorous : Animal
    {
        public Herbivorous(string? name, int? eats) : base(name, eats)
        {
        }

        public override void Eat(double massa)
        {
            Console.WriteLine("Ем траву");
            EatMassa += massa;
        }
    }
}
