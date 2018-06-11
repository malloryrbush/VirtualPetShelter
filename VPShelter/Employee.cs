using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        //EXTRA EMPLOYEE PROPERTY
        public int EmployeeID { get; set; }

        public Employee()
        {
            //DEFAULT CONSTRUCTOR
        }

        //METHODS
        public virtual string FeedPets()
        {
            return "All pets have been fed!";
        }

        public virtual string WaterPets()
        {
            return "You gave all the pets water!";
        }

        public virtual string PlayWithPets()
        {
            return "You played with all the pets!";
        }

        //ABSTRACT METHODS
        public abstract string ClockOut();

        public abstract string Adopt();

    }
}