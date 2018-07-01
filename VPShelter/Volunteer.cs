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