using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int passwordMinLenght = 6;
            const int passwordMaxLenght = 10;
            const int passwordDigitsCount = 2;
                   
            
            string password = Console.ReadLine();
            bool isPasswordValid = ValidatePassword(password, passwordMinLenght, passwordMaxLenght, passwordDigitsCount);
            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool ValidatePassword(string password,int passwordMinLenght,int passwordMaxLenght,int passwordDigitsCount)
        {
          
            bool isPassworsValid = true;
            if (!ValidatePasswordLength(password,passwordMinLenght,passwordMaxLenght))
            {
                Console.WriteLine($"Password must be between {passwordMinLenght} and {passwordMaxLenght} characters");
                isPassworsValid=false;
            }
            if (!ValidatePasswordDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPassworsValid = false;
            }
            if (!ValidatePasswordDigitsMinCount(password,passwordDigitsCount))
            {
                Console.WriteLine($"Password must have at least {passwordDigitsCount} digits");
                isPassworsValid = false;
            }
            return isPassworsValid;
        
        }
        static bool ValidatePasswordLength(string password,int minLenght,int maxLenght)
        {

            if (password.Length >= minLenght && password.Length <= maxLenght)
            {
                return true;
            }
            return false;
        }
        static bool ValidatePasswordDigits(string password)
        {
            foreach ( char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool ValidatePasswordDigitsMinCount(string password,int minDigitsCount)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitsCount++;
                }
                
            }
            return digitsCount >= minDigitsCount;
        }
    }
}
