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
        [TestMethod]
        //Checking for multiple mobile numbers
        [DataRow("91 9652545874", "Input is valid")]
        [DataRow("919652545874", "Input is not valid")]
        [DataRow("9144 9652545874", "Input is not valid")]
        [DataRow("91 1652545874", "Input is not valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenMobileNumberValidation(string mobileNumber, string expected) // Testing for mobile number Validation
        {
            try
            {
                //Act
                string actual = validation.MobileNumberValidation(mobileNumber);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfghnjvbn", "Input is valid")]
        [DataRow("ADF@#$%JVGB", "Input is valid")]
        [DataRow("FVGdf", "Input is not valid")]
        [DataRow("8745fgvhA", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPasswordRule1Validation(string password, string expected) // Testing for password rule 1 Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule1Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfghnjvbn", "Input is not valid")]
        [DataRow("A5sdf@#34", "Input is valid")]
        [DataRow("FVGdf", "Input is not valid")]
        [DataRow("wsdfgADFG65@3", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]      
        public void GivenPasswordRule2Validation(string password, string expected) // Testing for password rule 2 Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule2Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfgDnjvbn", "Input is not valid")]
        [DataRow("A5sdf@#df", "Input is valid")]
        [DataRow("F5G@f", "Input is not valid")]
        [DataRow("8465ADFG", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPasswordRule3Validation(string password, string expected) // Testing for password rule 3 Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule3Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfgDnjvbn", "Input is not valid")]
        [DataRow("A5sdf@df", "Input is valid")]
        [DataRow("F5G@f", "Input is not valid")]
        [DataRow("85ADcv*gj5", "Input is valid")]
        [DataRow("*&&dfgADDd845", "Input is not valid")]
        [DataRow("885@dfvvvb", "Input is not valid")]
        [DataRow("AAaa#8ghbb", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPasswordRule4Validation(string password, string expected) // Testing for password rule 4 along with all Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule4Validation(password);
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
