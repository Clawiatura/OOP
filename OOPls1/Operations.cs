using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace OOPls1
{
      class Operations
    {

        public List<string> values = new List<string>();

        public void AddValue(string value)
        {
            values.Add(value);
        }
        public void Delete(int index)
        {
            if (index <= values.Count)
            {
                values.RemoveAt(index-1);
            }
        }
        public int FindValue(string Values)
        {
            return values.IndexOf(Values);
        }
        public void Clear()
        {
            values.Clear();
        }
        public void Sort()
        {
            values.Sort();
        }
        public int Sum()
        {
            int sum = 0;
            foreach (string Value in values)
            {
                if (int.TryParse(Value, out int number))
                {
                    sum += number;
                }
            }
            return sum;
        }
        public int max()
        {
            int max = int.MinValue;
            foreach (string Value in values)
            {
                if (int.TryParse(Value, out int number))
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }
            }
            return max;

        }
        public int min()
        {
            int min = int.MaxValue;
            foreach (string Value in values)
            {
                if (int.TryParse(Value, out int number))
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }
            }
            return min;
        }
    }
}
