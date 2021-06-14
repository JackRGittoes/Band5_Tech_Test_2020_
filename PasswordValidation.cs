using System;
using System.Collections.Generic;
using System.Text;

namespace TechTestMondayBand5
{
    public class PasswordValidation : IPasswordValidation
    {
        public bool ContainsAtLeastOneDigit(string password)
        {
           foreach(char c in password)
            {
                if(char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsAtLeastOneLowercaseCharacter(string password)
        {
            foreach(char c in password)
            {
                if (c.ToString().ToLower() == c.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsAtleastOneSpecialCharacter(string password)
        {
            foreach(char c in password)
            {
                if(!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsAtLeastOneUppercaseCharacter(string password)
        {
            foreach (char c in password)
            {
                if (c.ToString().ToUpper() == c.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public bool LengthIsAtLeast6(string password)
        {
            return password.Length >= 6;
        }
    }
}
