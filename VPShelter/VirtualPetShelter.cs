using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPetShelter
    {

        public VirtualPetShelter()
        {
            //DEFAULT CONSTRUCTOR
        }

        public List<VirtualPet> pets = new List<VirtualPet>();
        List<Volunteer> volunteers = new List<Volunteer>();
        List<Manager> managers = new List<Manager>();

        public void SetVirtualPet(VirtualPet name)
        {
            pets.Add(name);
        }
        public void SetVolunteer(Volunteer volunteer)
        {
            volunteers.Add(volunteer);
        }
        public void SetManager(Manager manager)
        {
            managers.Add(manager);
        }
    }
}