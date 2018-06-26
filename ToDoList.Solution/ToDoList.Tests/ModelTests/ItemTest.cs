using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            //Arrange
            string description = "Walk the doggo.";
            Item newItem = new Item(description);

            //Act
            string result = newItem.GetDescription();

            //Assert
            Assert.AreEqual(description, result);
        }
        [TestMethod]
        public void GetDescription_SetDescription_String()
        {
            //Arrange
            string description = "Walk the doggo.";
            Item newItem = new Item(description);

            //Act
            newItem.SetDescription("Kiss the doggo.");
            string result = newItem.GetDescription();

            //Assert
            bool expectedResult = false;
            bool actualResult = description == result ? true : false;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
