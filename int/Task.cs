﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interf
{
    internal class Task: ITask, IComparable<Task>
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public int CompareTo(Task? other)
        {
            if (this.DueDate > other!.DueDate) return 1;
            else if (this.DueDate < other.DueDate) return -1;
            else return 0;
        }
        public void Display()
        {
            Console.WriteLine(Name + " " + DueDate + " " + Priority);
        }

    }
}
