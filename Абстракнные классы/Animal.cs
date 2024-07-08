using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстракнные_классы
{
    abstract class Animal
    {
        public string? Name;
        public int? Eats;

        protected Animal(string? name, int? eats)
        {
            Name = name;
            Eats = eats;
        }

        public double EatMassa { get; set; }
        public abstract void Eat(double massa);
        

        
    }
}
