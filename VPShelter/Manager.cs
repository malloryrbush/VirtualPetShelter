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
        //I got stuck trying to create the pet list, and then make the adoption method remove certain pets from the list. 
        //I thought it would be pets.Remove(name) but I'm really not sure and I couldn't get my list to display to the console to check if values were being passed into and being taken out of it.
        //So I really don't know if I was even trying to do it right because I couldn't figure out a way to check it. 
        //So in an effort to do anything, I just have the adoption method returning a string and in program class it writes whichever pet was chosen so it says "(petname) has been adopted

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