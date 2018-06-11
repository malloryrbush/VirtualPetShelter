using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HungerLevel { get; set; }
        public int ThirstLevel { get; set; }
        public int BoredLevel { get; set; }
        public bool AdoptionStatus { get; set; }

        public VirtualPet()
        {
            //DEFAULT CONSTRUCTOR
        }

        //CONSTRUCTOR CONTAINING ONLY NAME AND DESCRIPTION
        public VirtualPet(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }


        //OVERLOADED CONSTRUCTOR
        public VirtualPet(string Name, string Description, int HungerLevel, int ThirstLevel, int BoredLevel, bool AdoptionStatus)
        {
            this.Name = Name;
            this.Description = Description;
            this.HungerLevel = HungerLevel;
            this.ThirstLevel = ThirstLevel;
            this.BoredLevel = BoredLevel;
            this.AdoptionStatus = AdoptionStatus;
        }
        //I'm not really understanding why overloaded constructors are useful?

        public int GetHunger()
        {
            return HungerLevel;
        }

        public int GetThirst()
        {
            return ThirstLevel;
        }

        public int GetBored()
        {
            return BoredLevel;
        }
    }
}