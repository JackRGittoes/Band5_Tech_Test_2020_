using System;
using System.Collections.Generic;
using System.Text;

namespace TechTestMondayBand5
{
    public interface IPasswordValidation
    {
        bool LengthIsAtLeast6(string password);
        bool ContainsAtLeastOneDigit(string password);
        bool ContainsAtLeastOneLowercaseCharacter(string password);
        bool ContainsAtLeastOneUppercaseCharacter(string password);
        bool ContainsAtleastOneSpecialCharacter(string password);
    }
}
