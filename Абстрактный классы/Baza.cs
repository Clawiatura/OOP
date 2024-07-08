using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактный_классы
{
      abstract class Baza
    {
        public int CurrentFoodConsumed { get; set; }
        public int TypeFood {  get; set; }
        public string name { get; set; }
        //1 - мясо
        //2 - травушка
        
       public void food()
        {
            CurrentFoodConsumed = 0;
            CurrentFoodConsumed++;
           
            if (CurrentFoodConsumed >=10)
                Console.WriteLine("Животное не хочет больше есть");
            else Console.WriteLine("Животное можно покормить");
        }
        public void type()
        {
            if (TypeFood == 1)
            {
                Console.WriteLine($"{name} = хищник");
            }
            else if (TypeFood == 2)
            {
                Console.WriteLine($"{name} = травоядное");
            }
            else Console.WriteLine($"{name} Всеядное") ;
        }
        public void sort()
        {

        }


    }
}
