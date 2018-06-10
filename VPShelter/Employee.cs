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