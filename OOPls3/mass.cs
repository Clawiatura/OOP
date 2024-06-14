using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPls3
{
    internal class mass
    {
        private List<int> mas;
        public mass(int n) 
        {
            this.mas = new List<int>(n);
        }
        public int this[int index]
        {
            get
            {
                if(index >= 0 && index < mas.Count)
                    return mas[index];
                else throw new ArgumentOutOfRangeException();
            }
            set
            {
                if(index >=0 && index < mas.Count) mas[index] = value;
            }
        }
        public void Fill()
        {
            Random random = new Random();
            for (int i = 0;i <mas.Capacity;i++)
            {
                mas.Add(random.Next(0,100));
            }
        }
        public void Mix()
        {
            Random random = new Random();
            for(int i = 0; i < random.Next(mas.Count); i++)
            {
                int x = random.Next(mas.Count);
                int y = random.Next(mas.Count);
                int temp = mas[x];
                mas[x] = mas[y];
                mas[y] = temp;
            }

        }
        public int Diff()
        {
           List <int > temp = new List <int>();
            foreach(int i in mas)
            {
                if(!temp.Contains(i)) temp.Add(i);
            }
            return temp.Count;
        }
        public void Prin()
        {
            foreach (int i in mas)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
