using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    abstract class Volunteer : Employee
    {
        //EXTRA VOLUNTEER PROPERTY
        public string Specialty { get; set; }

        //REQUIRED OVERRIDE METHOD
        public override void ClockOut()
        {
            
        }
    }
}

//The requirements say Volunteer class must include a method to feed and give water to all of the pets,
//but I wanted the manager to also be able to do these things.
//So I put those methods in Employee class since Volunteer and Manager are derived from it and will inherently have those methods.
//But here they are again anyway in case that's cheating :)
//
//
// public void FeedPets()
// {
//
// }
//
//
//public void WaterPets()
// {

// }