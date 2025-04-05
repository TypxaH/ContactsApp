using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Services
{
    static class Validator
    {
        public static bool IsValidName(string contactName, out string message)
        {
            if (contactName.Length < 3 || contactName.Length > 100)
            {
                message = "Името трябва да съдържа между 3 и 100 символа включително!";
                return false;
            }
            message = "ok";
            return true;
        }

        public static bool IsValidNumber(string contactNumber, out string message)
        {
            if (contactNumber.Length < 6 || contactNumber.Length > 10)
            {
                message = "Номерът на контакта трябва да съдържа между 6 и 10 цифри включително!";
                return false;
            }
            else if (!IsOnlyDigits(contactNumber))
            {
                message = "Номерът на контакта трябва да съдържа само цифри!";
                return false;
            }
            message = "ok";
            return true;
        }

        private static bool IsOnlyDigits(string contactNumber)
        {
            foreach (var digit in contactNumber)
            {
                if (!char.IsDigit(digit))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
