using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPls5
{
    internal class Mas
    {
        private string[] massiv1;
        private string[] massiv2;
        private int lenght;

        public Mas(int lengh)
        {
            lenght = lengh;
            massiv1 = new string[lengh];
            massiv2 = new string[lengh];
        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= lenght)
                {
                    throw new IndexOutOfRangeException("Массив больше заданной длины");
                }
                return massiv1[index];
            }
        
            set 
            {
                if (index < 0 || index >= lenght)
                {
                    throw new ArgumentOutOfRangeException("Массив больше заданной длины");
                }
                massiv1[index] = value;
            }
            
        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= lenght)
                {
                    throw new IndexOutOfRangeException("Массив больше заданной длины");
                }
                return massiv2[index];
            }

            set
            {
                if (index < 0 || index >= lenght)
                {
                    throw new ArgumentOutOfRangeException("Массив больше заданной длины");
                }
                massiv2[index] = value;
            }

        }
        public void sum()
        {

        }
        public string Conc()
        {
            string result = "";
            foreach (string str in massiv1)
            {
                result += str;
            }
            return result;
        }
                     
    }
}

