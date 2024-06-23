using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP10
{
    public class Pair
    {
        public int number;
        
        public virtual int this[int index]
        {
            get
            {
                return numb(number,index);
            }
        }
        public int numb (int number, int index)
        {
            for (int i = 0; i < index; i++)
            {
                number /= 10;
            }
            return number % 10;
        }
    }
    public class  PairClass : Pair
    {
        public int number1;

        public override int this[int index1,int index2]
        {
            get
            {
                if (index2 == 0)
                {
                    return numb(number, index1);
                }
                else if (index2 == 1)
                {
                    return numb(number1, index1);
                }
                else
                {
                    return -1;
                }
            }

        }
        public override int this[int index]
        {
            get
            {
                int sum = number + number1;
                return numb(sum, index);
            }
        }
        
        
    }
}
