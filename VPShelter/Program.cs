using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Program
    {
        static void Main(string[] args)
        {
            VirtualPet pickle = new VirtualPet("Pickle", "Blue nose pitbull", 5, 10, 15, false);
            VirtualPet madison = new VirtualPet("Madison", "German Shepherd", 5, 10, 15, false);
            Manager manager = new Manager(10546513, 35000);
            Volunteer volunteer = new Volunteer(11356797, "dog walking");
            VirtualPetShelter capl = new VirtualPetShelter();

            int empType;
            int volunteerAction;
            int managerAction;
            string exitResp;
            int adoptResp;
            int checkStatus;
            int feedPet;
            int waterPet;
            int playWithPet;

            Console.WriteLine("Welcome to the Cleveland Animal Protective League.");
            Console.WriteLine("Type yes to enter.");
            exitResp = Console.ReadLine().ToLower();
            Console.Clear();

            while (exitResp == "yes")
            {

                Console.WriteLine("Which type of employee are you?");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Volunteer");
                empType = int.Parse(Console.ReadLine());
                Console.Clear();

                while (empType == 1)
                {

                    if (empType == 1)
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
                        Console.WriteLine("6. Return to main menu");
                        managerAction = int.Parse(Console.ReadLine());

                        //MANAGER SWITCH STATEMENT
                        switch (managerAction)
                        {
                            case 1:
                                Console.WriteLine("Which pet would you like to check on?");
                                Console.WriteLine("1. Pickle");
                                Console.WriteLine("2. Madison");
                                checkStatus = int.Parse(Console.ReadLine());

                                if (checkStatus == 1)
                                {
                                    Console.WriteLine("Hunger: {0}%", pickle.GetHunger());
                                    Console.WriteLine("Thirst: {0}%", pickle.GetThirst());
                                    Console.WriteLine("Boredom: {0}%", pickle.GetBored());
                                }

                                if (checkStatus == 2)
                                {
                                    Console.WriteLine("Hunger: {0}%", madison.GetHunger());
                                    Console.WriteLine("Thirst: {0}%", madison.GetThirst());
                                    Console.WriteLine("Boredom: {0}%", madison.GetBored());
                                }
                                break;
                                Console.Clear();

                            case 2:
                                Console.WriteLine("Which pet would you like to adopt?");
                                Console.WriteLine("The pets available are:");
                                Console.WriteLine("1. {0}: {1}", pickle.Name, pickle.Description);
                                Console.WriteLine("2. {0}: {1}", madison.Name, madison.Description);
                                adoptResp = int.Parse(Console.ReadLine());

                                if (adoptResp == 1)
                                {
                                    Console.WriteLine("{0} {1}", pickle.Name, manager.Adopt());
                                }
                                if (adoptResp == 2)
                                {
                                    Console.WriteLine("{0} {1}", madison.Name, manager.Adopt());
                                }
                                break;
                                Console.Clear();

                            case 3:
                                Console.WriteLine("Which pet would you like to feed?");
                                Console.WriteLine("1. Pickle");
                                Console.WriteLine("2. Madison");
                                feedPet = int.Parse(Console.ReadLine());

                                if (feedPet == 1)
                                {
                                    Console.WriteLine("{0} {1}", pickle.Name, manager.FeedPets());
                                }

                                if (feedPet == 2)
                                {
                                    Console.WriteLine("{0} {1}", madison.Name, manager.FeedPets());
                                }
                                break;
                                Console.Clear();

                            case 4:
                                Console.WriteLine("Which pet would you like to give water to?");
                                Console.WriteLine("1. Pickle");
                                Console.WriteLine("2. Madison");
                                waterPet = int.Parse(Console.ReadLine());

                                if (waterPet == 1)
                                {
                                    Console.WriteLine("{0} {1}", pickle.Name, manager.WaterPets());
                                }

                                if (waterPet == 2)
                                {
                                    Console.WriteLine("{0} {1}", madison.Name, manager.WaterPets());
                                }
                                break;
                                Console.Clear();

                            case 5:
                                Console.WriteLine("Which pet would you like to play with?");
                                Console.WriteLine("1. Pickle");
                                Console.WriteLine("2. Madison");
                                playWithPet = int.Parse(Console.ReadLine());

                                if (playWithPet == 1)
                                {
                                    Console.WriteLine("{0} {1}", pickle.Name, manager.PlayWithPets());
                                }

                                if (playWithPet == 2)
                                {
                                    Console.WriteLine("{0} {1}", madison.Name, manager.PlayWithPets());
                                }
                                break;

                            case 6:
                                Console.WriteLine("Which type of employee are you?");
                                Console.WriteLine("1. Manager");
                                Console.WriteLine("2. Volunteer");
                                empType = int.Parse(Console.ReadLine());
                                Console.Clear();

                                break;
                        }

                    }
                }
                while (empType == 2)
                {

                    if (empType == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Thanks for volunteering!");
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("");
                        Console.WriteLine("1. View pet status");
                        Console.WriteLine("2. Feed the pets");
                        Console.WriteLine("3. Give the pets water");
                        Console.WriteLine("4. Play with a pet");
                        Console.WriteLine("5. Return to main menu");
                        volunteerAction = int.Parse(Console.ReadLine());

                        //VOLUNTEER SWITCH STATEMENT
                        switch (volunteerAction)
                        {
                            case 1:
                                Console.WriteLine("Which pet would you like to check on?");
                                Console.WriteLine("1. Pickle");
                                Console.WriteLine("2. Madison");
                                checkStatus = int.Parse(Console.ReadLine());

                                if (checkStatus == 1)
                                {
                                    Console.WriteLine("Hunger: {0}%", pickle.GetHunger());
                                    Console.WriteLine("Thirst: {0}%", pickle.GetThirst());
                                    Console.WriteLine("Boredom: {0}%", pickle.GetBored());
                                }

                                if (checkStatus == 2)
                                {
                                    Console.WriteLine("Hunger: {0}%", madison.GetHunger());
                                    Console.WriteLine("Thirst: {0}%", madison.GetThirst());
                                    Console.WriteLine("Boredom: {0}%", madison.GetBored());
                                }
                                break;
                                Console.Clear();

                            case 2:
                                Console.WriteLine(volunteer.FeedPets());
                                break;
                                Console.Clear();

                            case 3:
                                Console.WriteLine(volunteer.WaterPets());
                                break;
                                Console.Clear();

                            case 4:
                                Console.WriteLine("Which pet would you like to play with?");
                                Console.WriteLine("1. Pickle");
                                Console.WriteLine("2. Madison");
                                playWithPet = int.Parse(Console.ReadLine());

                                if (playWithPet == 1)
                                {
                                    Console.WriteLine("{0} {1}", pickle.Name, volunteer.PlayWithPets());
                                }

                                if (playWithPet == 2)
                                {
                                    Console.WriteLine("{0} {1}", madison.Name, volunteer.PlayWithPets());
                                }
                                break;

                            case 5:
                                Console.WriteLine("Which type of employee are you?");
                                Console.WriteLine("1. Manager");
                                Console.WriteLine("2. Volunteer");
                                empType = int.Parse(Console.ReadLine());
                                Console.Clear();
                                break;

                        }

                    }

                }
            }
        }
    }
}