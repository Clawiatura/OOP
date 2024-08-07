using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Anima<T> where T : IlistAnimal
    {
        public List<T> Animalist = new List<T>();
        public void add(T animals)
        {  
            Animalist.Add(animals); 
        }
       public List<T> get()
        { 
            return Animalist; 
        }
        public T GetConcreteAnimal(int id)
        {
            return Animalist.FirstOrDefault(b => b.id == id);
        }
    }
    
    
       
    
}
