using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationWithException
{
    public class Validation
    {
        public string FirstNameValidation(string fName) // Creating a method for First name validation
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$"; // Regex for first name validation
                if (fName == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when first name is null
                }
                if (fName.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when first name is empty
                }                 
                if (Regex.IsMatch(fName, pattern)) //If name entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour first name \"{fName}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input is not valid");//throwing exception when first name is not valid
                }
                
            }
            catch(InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        public string LastNameValidation(string lName) // Creating a method for last name validation
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$"; // Regex for last name validation
                if (lName == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when last name is null
                }
                if (lName.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when last name is empty
                }
                if (Regex.IsMatch(lName, pattern)) //If last name entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour first name \"{lName}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input is not valid");//throwing exception when lastt name is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        public string EmailValidation(string email) // Creating a method for email name validation
        {
            try
            {
                string pattern = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$"; // Regex for email validation
                if (email == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when email is null
                }
                if (email.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when email is empty
                }
                if (Regex.IsMatch(email, pattern)) //If name entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour first name \"{email}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input is not valid");//throwing exception when email is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
    }
}
