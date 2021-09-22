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
        public void Pets_In_Shelter()
        {
            foreach(Pet MyPet in ListOfPets)
            {
                Console.WriteLine(MyPet.Name);
            }
        }
    }
}
