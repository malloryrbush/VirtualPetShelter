using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        //EXTRA VOLUNTEER PROPERTY
        public string Specialty { get; set; }

        public Volunteer(int EmployeeID, string Specialty)
        {
            this.EmployeeID = EmployeeID;
            this.Specialty = Specialty;
        }

        //REQUIRED OVERRIDE METHOD
        public override string ClockOut()
        {
            return "Thanks for volunteering!";
        }

        public override string Adopt()
        {
            throw new NotImplementedException();
        }

        public override string PlayWithPets()
        {
            return "has been played with";
        }
    }
}

//The requirements say Volunteer class must include a method to feed and give water to all of the pets,
//but I wanted the manager to also be able to do these things.
//So I put those methods in Employee class since Volunteer and Manager are derived from it and will inherently have those methods.
//But here they are again anyway in case that's cheating.
//
//
//public string FeedPets()
//{
//    return "All pets have been fed!";
//}

//public string WaterPets()
//{
//    return "You gave all the pets water!";
//}