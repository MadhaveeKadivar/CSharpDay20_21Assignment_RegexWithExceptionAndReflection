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
        //Checking for multiple first names
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
        [TestMethod]
        //Checking for multiple last names
        [DataRow("Kadivar", "Input is valid")]
        [DataRow("Ab", "Input is not valid")]
        [DataRow("kadivar", "Input is not valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenLastNameValidation(string lastName, string expected) // Testing for Lastname Validation
        {
            try
            {
                //Act
                string actual = validation.LastNameValidation(lastName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        //Checking for multiple email samples
        [DataRow("abc123@.com", "Input is not valid")]
        [DataRow("abc@abc@gmail.com", "Input is not valid")]
        [DataRow("abc+100@gmail.com", "Input is valid")]
        [DataRow("abc@1.com", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenEmailValidation(string email, string expected) // Testing for Lastname Validation
        {
            try
            {
                //Act
                string actual = validation.EmailValidation(email);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
