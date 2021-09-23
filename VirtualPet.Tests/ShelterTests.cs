using System;
using Xunit;
using System.Collections.Generic;


namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        [Fact]
        public void Should_List_All_Pets_In_Shelter()
        {
            //Arrange
            Shelter shelter = new Shelter();
            Pet myPet = new Pet("Gavin", "Pokemon");
            //Act
            shelter.AddPet(myPet);
            //Assert
            Assert.Contains(myPet, shelter.ListOfPets);
        }
        [Fact]
        public void AddPet_Should_Increase_List_Length_By_One()
        {
            //Arrange
            //Set up variable/Get the objects you want to work with
            Shelter shelter = new Shelter();
            Pet pet = new Pet("Davis", "Cat");

            //Act
            //Run the method that we are testing
            shelter.AddPet(pet);
            //You are taking an object and adding a pet to the shelter using the addPet method

            //Assert
            int count = shelter.ListOfPets.Count;
            Assert.Equal(1, count);
            //In the parenthesis we need two things.
            //One is what we expect the answer to be 
            //Two is the value we are actually getting
        }
        public void AdoptPet_Should_Decrease_List_Length_By_One()
        {
            Shelter shelter = new Shelter();
            Pet pet = new Pet("Name", "Species");
            shelter.AdoptPet(pet);
            int count = shelter.ListOfPets.Count;
            Assert.Equal(0, count);
        }
       


    }
}
