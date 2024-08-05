using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sotrudnik
{
    internal class Employee: IComparable<Employee>, IEnumerable<Tusk>
    {
        public string? name { get; set; }
        public int? id { get; set; }
        public List<Tusk> Tusks { get; set; }

        

        
        public int CompareTo(Employee? other)
        {
            int taskComparison = this.Tusks.Count.CompareTo(other.Tusks.Count);

            if (taskComparison == 0)
            {
                var thisTaskPriority = this.Tusks.Count > 0 ? this.Tusks[0].Priority : "";

                var otherTaskPriority = other.Tusks.Count > 0 ? other.Tusks[0].Priority : "";

                return thisTaskPriority.CompareTo(otherTaskPriority);
            }
            return taskComparison;
        }



        public IEnumerator<Tusk> GetEnumerator()
        {
            return Tusks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

