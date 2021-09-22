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
            Pet myPet = new Pet("Gavin","Pokemon");
            //Act
            shelter.AddPet(myPet);
            //Assert
            Assert.Contains(myPet, shelter.ListOfPets);
        }

    }
}
