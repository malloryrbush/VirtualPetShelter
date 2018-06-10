using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        //FIELDS/PROPERTIES
        public int EmployeeID { get; set; }

        //METHODS
        public void FeedPets()
        {

        }

        public void WaterPets()
        {

        }

        public void ViewStatus()
        {

        }

        public void PlayWithPets()
        {

        }

        //ABSTRACT METHODS
        public abstract void ClockOut();

        public abstract void Adopt();

    }

    

}