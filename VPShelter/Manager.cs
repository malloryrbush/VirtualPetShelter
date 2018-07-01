using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        //EXTRA MANAGER PROPERTY
        public int Salary { get; set; }

        public Manager(int EmployeeID, int Salary)
        {
            this.EmployeeID = EmployeeID;
            this.Salary = Salary;
        }

        //REQUIRED OVERRIDE METHOD
        public override string Adopt()
        {
            return "has been adopted!";
        }

        public override string ClockOut()
        {
            return "Have a good day";
        }

        //METHODS
        public override string FeedPets()
        {
            return "has been fed!";
        }

        public override string WaterPets()
        {
            return "got water!";
        }

        public override string PlayWithPets()
        {
            return "has been played with";
        }
    }
}