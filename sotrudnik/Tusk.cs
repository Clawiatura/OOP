using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sotrudnik
{
    internal class Tusk:ICloneable
    {
        public string? TitleName { get; set; }
        public string? Priority { get; set; }
        public DateTime DateEnd { get; set; }

        public object Clone()
        {
            return new Tusk { TitleName = this.TitleName, Priority = this.Priority, DateEnd = this.DateEnd };
        }
    }
}
