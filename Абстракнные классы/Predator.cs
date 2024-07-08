using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстракнные_классы
{
    internal class Predator : Animal
    {
        public Predator(string? name, int? eats) : base(name, eats)
        {
        }

        public override void Eat(double massa)
        {
            Console.WriteLine("Ем мясо");
            EatMassa += massa;
        }
    }
}
