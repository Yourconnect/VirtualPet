using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {


        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        //public int Feed { get; set; }  Not property Should be method
        //public int SeeDoctor { get; set; }
        //public int Play { get; set; }

        public void Play()
        {
            Hunger += 5;
            Boredom -= 5;

        }
        public void Feed()
        {
            Hunger -= 5;
            Health += 10;
        }
        public void Doctor()
        {
            Hunger = 50;
            Boredom = 50;
            Health = 100;
        }
        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("");
        }
        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 50;
            Boredom = 50;
            Health = 100;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species;
        }
        public void GetStatus()
        {
            Console.WriteLine("Hunger:" + Hunger + "Boredom:" + Boredom + "Health:" + Health);
        }    
        public int GetHunger()
        {
          return Hunger;
        }
        public int GetBoredom()
        {
            return Boredom;
        }
        public int GetHealth()
        {
            return Health;
        }
        public void FeedDecreaseHunger()
        {
            Hunger = 50;

            int Feed()
            {
               Hunger -= 40;
               
               return Feed();
            }

            
        }
        public void SeeDoctor()
        {
            Health = 100;

            int Doctor()
            {
                Health += 30;

                return Doctor();
            }

        }
        public void PlayIncreaseHunger()
        {
            Hunger = 50;

            int Play()
            {
                Hunger += 10;

                return Play();
            }
        }
        public void PlayDecreaseBoredom()
        {
            Boredom = 50;

            int Play()
            {
                Boredom -= 20;

                return Play();
            }
        }
        public void PlayIncreaseHealth()
        {
            Health = 100;

            int Play()
            {
                Health += 10;

                return Play();
            }
        }
        
    }
}
