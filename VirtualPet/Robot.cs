using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
   public class Robot : Pet
    {
        public string Fly { get; set; }

        public void Fly()
        {
            Hunger += 5;
            Boredom -= 5;
        }
        public void Transform()
        {
            Boredom -= 10;
            Hunger += 5;
        }
        public void Hack()
        {
            Boredom -= 10;
            Hunger += 5;
        }
    } 
}