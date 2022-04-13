using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationWithException;
using System;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UserInputTesting
    {
        Validation validation;
        [TestInitialize]
        public void SetUp()
        {
            // common Arrange
            validation = new Validation();
        }
        [TestMethod]
        //Checking for multiple first name
        [DataRow("Madhavee", "Input is valid")]
        [DataRow("Ab", "Input is not valid")]
        [DataRow("madhavee", "Input is not valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null,"Input should not be null")]
        public void GivenFirstNameValidation(string firstName, string expected) // Testing for Firstname Validation
        {
            try
            {
                //Act
                string actual = validation.FirstNameValidation(firstName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch(InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
