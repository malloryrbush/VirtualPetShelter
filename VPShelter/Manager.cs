using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Manager : Employee
    {
        //EXTRA MANAGER PROPERTY
        public int Salary { get; set; }

        //REQUIRED OVERRIDE METHOD
        public override void Adopt()
        {
            
        }
    }
}