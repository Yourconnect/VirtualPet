using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the shelter");
                Console.WriteLine("Would you like to play? ");
                Console.WriteLine("Please select one of the following: ");
                Console.WriteLine("1.Check in a pet");
                Console.WriteLine("2.Play with a animal");
                Console.WriteLine("3.Adopt an animal");
                Console.WriteLine("4.Feed an animal");
                Console.WriteLine("5.Take an animal to the vet");
                Console.WriteLine("6.");
                Console.WriteLine("7.");
                Console.WriteLine("8.");
                Console.WriteLine("9.");
                Console.WriteLine("10.");
                Console.WriteLine("11.");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":

                        break;
                    case "9":

                        break;
                    case "10":

                        break;
                    case "11":

                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Aww that sucks :( Good bye then!");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
