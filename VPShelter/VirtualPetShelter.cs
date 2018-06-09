using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPetShelter
    {
        List<VirtualPet> pets = new List<VirtualPet>();
        List<Employee> employees = new List<Employee>();
        List<Volunteer> volunteers = new List<Volunteer>();
        List<Manager> managers = new List<Manager>();


        public void SetVirtualPet(VirtualPet pets)
        {
            pets.Add(pets);
        }
        public void SetEmployee(Employee employees)
        {
            employees.Add(employees);
        }
        public void SetVolunteer(Volunteer volunteers)
        {
            volunteers.Add(volunteers);
        }
        public void SetManager(Manager managers)
        {
            managers.Add(managers);
        }

        //Getting the objects is the list 
        public List<VirtualPet> GetVirtualPet()
        {
            return pets;
        }
        public List<Employee> GetEmployee()
        {
            return employees;
        }
        public List<Volunteer> GetVolunteer()
        {
            return volunteers;
        }
        public List<Manager> GetManager()
        {
            return managers;
        }
    }
}