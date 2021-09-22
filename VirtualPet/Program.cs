using System;

namespace VirtualPet
{
    class Program
    {
        public static Pet MyPet;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Shelter!");
            bool Menu = true;

            while (Menu)
            {
                Console.Clear();
                Console.WriteLine("How can we help you today?");
                Console.WriteLine("Please select one of the following: ");
                Console.WriteLine("1.Admit a pet");
                Console.WriteLine("2.Check status of a pet");
                Console.WriteLine("3.Interact with a pet");
                Console.WriteLine("4.Adopt a pet");
                Console.WriteLine("5.Leave the shelter");



                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        MyPet=NewPet();
                        
                        break;
                    case "2":
                        PrintStatus();
                        

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    
                        Menu = false;
                        Console.WriteLine("Thanks for visiting the shelter");
                        break;
                    default:
                        break;
                }
            }
            
            static Pet NewPet()
            {
                Console.WriteLine("What species is your pet?");
                string Species = Console.ReadLine();
                Console.WriteLine("What is the name of your pet?");
                string Name = Console.ReadLine();
                return new Pet(Species, Name);
            }   
            
            static void PrintStatus()
            {
                Console.WriteLine("Hunger: "+ MyPet.Hunger);
                Console.WriteLine("Boredom: "+ MyPet.Boredom);
                Console.WriteLine("Health: "+ MyPet.Health);
                Console.Read();

            }

            
           
        }
    }
}
