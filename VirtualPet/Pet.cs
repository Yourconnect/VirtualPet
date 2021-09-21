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

        public Pet()
        {
            Hunger = 50;
            Boredom = 50;
            Health = 100;

        }

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;

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
    }
}
