using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animal
    {
        
        public string? NickName { get; set; }
        public string? Breed { get; set; }
        public int? Age { get; set; }
        public DateTime AcceptanceDate { get; set; }
    }
    public interface IlistAnimal
    {
        int id { get;  set;}
    }
}
