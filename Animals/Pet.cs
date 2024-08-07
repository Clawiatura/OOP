using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Pet : Animal, IlistAnimal
    {
        
        int IlistAnimal.id { get; set; }

        public Pet(int id, string nickname, string breed, DateTime acceptanceDate, int age)
        {
            id = id;
            NickName = nickname;
            Breed = breed;
            AcceptanceDate = acceptanceDate;
            Age = age;
        }
    }
}
