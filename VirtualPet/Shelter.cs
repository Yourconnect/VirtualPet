using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Shelter
    {
        public List<Pet> ListOfPets = new List<Pet>();
        public void PetsInShelter()
        {
            foreach (Pet MyPet in ListOfPets)
            {
                Console.WriteLine(MyPet.Name);
            }
        }
        public void AddPet(Pet o)
        {
            ListOfPets.Add(o);

        }
        public void AdoptPet(Pet o)
        {
            ListOfPets.Remove(o);

        }
        public Pet PetChoiceList()
        {
            int i = 1;
            foreach (Pet pet in ListOfPets)

            {
                Console.WriteLine(i + " " + pet.Name + " " + pet.Species);
                i++;
            }
            return PetChoiceList();
        }
        
    }
}
