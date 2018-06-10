using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {

        string empType;
            int volunteerAction;
            int managerAction;

        Console.WriteLine("Welcome to the Cleveland Animal Protective League.");
            Console.WriteLine("Which type of employee are you?");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Volunteer");
            empType = Console.ReadLine();

            if (empType == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to work!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("");
                Console.WriteLine("1. View pet status");
                Console.WriteLine("2. Adopt a pet");
                Console.WriteLine("3. Feed the pets");
                Console.WriteLine("4. Give the pets water");
                Console.WriteLine("5. Play with a pet");
                managerAction = int.Parse(Console.ReadLine());

                //MANAGER SWITCH STATEMENT
                switch (managerAction)
                {
                    case 1:
                        Pickle.GetStatus();
                        break;

                    case 2:
                        Console.WriteLine("[PET] has been adopted!");
                        break;

                    case 3:
                        Console.WriteLine("Thanks for feeding the pets!");
                        break;

                    case 4:
                        Console.WriteLine("Thanks for giving the pets water!");
                        break;

                    case 5:
                        Console.WriteLine("Thanks for playing with the pets! They had fun.");
                        break;
                }
            }

            if (empType == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Thanks for volunteering!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("");
                Console.WriteLine("1. View pet status");
                Console.WriteLine("2. Feed the pets");
                Console.WriteLine("3. Give the pets water");
                Console.WriteLine("4. Play with a pet");
                volunteerAction = int.Parse(Console.ReadLine());
            
                //VOLUNTEER SWITCH STATEMENT
                switch (volunteerAction)
                {
                    case 1:
                        Pickle.GetStatus();
                        break;

                    case 2:
                        Console.WriteLine("Thanks for feeding the pets!");
                        break;

                    case 3:
                        Console.WriteLine("Thanks for giving the pets water!");
                        break;

                    case 4:
                        Console.WriteLine("Thanks for playing with the pets! They had fun.");
                        break;

                }

            }
           
        }
    }
}