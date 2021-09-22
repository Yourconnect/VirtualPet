using System;
using Xunit;


namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        [Fact]
        public void Should_List_All_Pets_In_Shelter()
        {
            //Arrange
            Shelter shelter = new Shelter();
            //Act

            //Assert
            Assert.Equal(ListOfPets, shelter.GetName);
        }

    }
}
