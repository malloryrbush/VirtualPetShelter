using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Dog : VirtualPet
    {
        public string TypeOfAnimal { get; set; }
        public string Diet { get; set; }

        public Dog(string TypeOfAnimal, string Diet)
        {
            this.TypeOfAnimal = TypeOfAnimal;
            this.Diet = Diet;
        }
    }
}