using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Вертуальные_методы;

namespace Вертуальные_методы
{
     class intNumber
    {
        public int number;

        public virtual int this[int index]

        {
            get
            {
                return (int)Math.Floor((number % Math.Pow(10, index + 1)) / Math.Pow(10, index));
            }
        }
    }
}



