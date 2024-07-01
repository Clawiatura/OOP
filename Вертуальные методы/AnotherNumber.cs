using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вертуальные_методы
{
    class AnotherNumber : intNumber
    {
        public int anotherNumber;

        public int this[int index1, int index2]
        {
            get
            {
                if (index1 == 0)
                {
                    return (int)Math.Floor((number % Math.Pow(10, index2 + 1)) / Math.Pow(10, index2));
                }
                else if (index1 == 1)
                {
                    return (int)Math.Floor((anotherNumber % Math.Pow(10, index2 + 1)) / Math.Pow(10, index2));
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
    
