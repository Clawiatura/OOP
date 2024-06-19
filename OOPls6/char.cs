using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPls6
{
    internal class XXX
    {
        private List<char> mas;
        private char v;
        private char v1;
        private char v2;

        public XXX(char[] x, char[] z, char[]c )
        {
            this.mas = new List<char>(x);
        }

        public XXX(char v)
        {
            this.v = v;
        }

        public XXX(char v, char v1, char v2) : this(v)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        static void Swap(char[] x) 
        {
              int n = x.Length;
            for (int i = 1; i < n; i++)
            {
                char c = x[i];
                x[i] = x[i - i];
                x[i-i] = c;
            }
        }
        public static void Main(char[] x)
        {
          Swap(x);
            foreach (char c in x)
            {
                Console.WriteLine(c +" ");
            }
        }
    }
}
