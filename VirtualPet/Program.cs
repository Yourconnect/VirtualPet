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
                       // GetStatus();
                        

                        break;
                    case "3":
                        PetInteractions();
                        break;
                    case "4":
                        AdoptPet();

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
            
            //static void PrintStatus()
            //{

            //    Console.Clear();
            //    Console.WriteLine("Hunger: "+ MyPet.Hunger);
            //    Console.WriteLine("Boredom: "+ MyPet.Boredom);
            //    Console.WriteLine("Health: "+ MyPet.Health);
            //    Console.Read();

            }



            static void AdoptPet()
            {
                Console.WriteLine("Would you like to adopt " + MyPet + "?");
                Console.WriteLine("Yes or No?");

                string choice = Console.ReadLine().ToLower();
                if (choice == "yes")
                {
                    //MyPet.Remove();?? remove from pet list in shelter
                    Console.WriteLine("Enjoy your new pet!");
                }
                else
                {
                    Console.WriteLine("Come back when you want to save a helpless animal");
                }

                Console.Read();
                

            }

            static void PetInteractions()
            {
                Console.WriteLine("How would you like to interact with a pet today? ");
                Console.WriteLine("Enter 1 to play with the pet \n Enter 2 to feed the pet \n Enter 3 to take the pet to the doctor");
                int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine(MyPet.Name + " is " + MyPet.Boredom + "% bored");

                //MyPet.Play;

                Console.WriteLine(MyPet.Name + " is playing");

                Console.WriteLine(MyPet.Name + "is now " + MyPet.Boredom + "% bored");

            }
            else if (choice == 2)
            {
                //MyPet.Feed;
            }
            else if (choice == 3)
            {
                //MyPet.Doctor

                Console.WriteLine(");
            }
            else
            {
                Console.WriteLine("Please choose option 1, 2 or 3");
            }


               

            }
           
        }
    }
}
