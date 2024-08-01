using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Building
    {
        public string BuildingName { get; set; }
        public double Height { get; set; }
        public int Floors { get; set; }
        public double TotalArea { get; set; }
        public string Location { get; set; }

        public double CalculateVolume()
        {
            return Height * TotalArea;  
        }
        public delegate double VolumeCalculator(Building building);

    }
}
