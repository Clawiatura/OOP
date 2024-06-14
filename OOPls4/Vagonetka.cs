using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPls4
{
    class Vagonetka
    {
        public int VagonNumber { get; set; }
        public string VagonClass { get; set; }
        public int TotalSeats { get; set; }
        public int PassengersExit { get; set; }
        public int BilletSell { get; set; }

        public Vagonetka(int vagonNumber, string vagonClass, int totalSeats)
        {
            VagonNumber = vagonNumber;
            VagonClass = vagonClass;
            TotalSeats = totalSeats;
            PassengersExit = 0;
            BilletSell = 0;
        }
        public void exit(int passengersExit)
        {
            PassengersExit += passengersExit;
        }
        public void sell(int billetSell)
        {
            BilletSell += billetSell;
        }
        public void Current()
        {
            if (PassengersExit + BilletSell <= TotalSeats)
            {
                int CurrentSeats = TotalSeats - PassengersExit - BilletSell;
                Console.WriteLine("Свободных мест в вагоне" + " " + VagonNumber + ":" + CurrentSeats);
            }
            else Console.WriteLine($"Свободных сидячих мест в вагоне: {VagonNumber} - нет, езжайте стоя");
        }

    }
}
