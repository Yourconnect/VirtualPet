using System;
using Xunit;
using System.Collections.Generic;

namespace VirtualPet.Tests
{ 
    //SleepMode = Boredom
    //Hack = Play
    //Charge = Hunger

    public class RobotTests      
    {
        private Robot testPet;

        public PetTests()
        {
            testPet = new Robot("Species", "Name");
        }
        [Fact]
        public void Hack_Should_Decrease_Oil_By_5()
        {
            //Act
            testPet.Play();
            //Assert
            Assert.Equal(25, testPet.GetHealth);
        }
        [Fact]
        public void Hack_Should_Decrease_SleepMode_By_10()
        {
            //Act
            testPet.Play();

            //Assert
            Assert.Equal(50, testPet.GetBoredom);
        }
        [Fact]
        public void Mechanic_Should_Increase_SleepMode_By_5()
        {
            //Act
            testPet.Doctor();
            //Assert
            Assert.Equal(65, testPet.GetBoredom);
        }
        [Fact]
        public void Mechanic_Should_Increase_ChargeLvl_By_5()
        {
            testPet.Doctor();

            Assert.Equal(55, testPet.GetHunger);
        }
        public void Mechanic_Should_Increase_Oil_By_10()
        {
            testPet.Doctor();
            
            Assert.Equal(40, testPet.GetHealth);
        }
        public void ChargeLvl_Should_Increase_Hunger_By_5()
        {
            testPet.Feed();

            Assert.Equal(55, testPet.GetHunger);
        }
        public void ChargeLvl_Should_Decrease_Boredom_By_5()
        {
            testPet.Feed();

            Assert.Equal(55, testPet.GetBoredom);
        }
    }
}
