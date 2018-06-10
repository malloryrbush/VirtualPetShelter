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


        public void SetVirtualPet(VirtualPet pet)
        {
            pets.Add(pet);
        }
        public void SetEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void SetVolunteer(Volunteer volunteer)
        {
            volunteers.Add(volunteer);
        }
        public void SetManager(Manager manager)
        {
            managers.Add(manager);
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