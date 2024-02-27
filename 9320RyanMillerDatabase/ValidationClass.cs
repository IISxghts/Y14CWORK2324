using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _9320RyanMillerDatabase
{
    internal class ValidationClass
    {
    
        public static bool PostcodeChecker(string postcode)
        {
            Regex regex = new Regex(@"^[A-Z]{1,2}[0-9R][0-9A-Z]? [0-9][ABD-HJLNP-UW-Z]{2}$");

            return regex.IsMatch(postcode);
        }

        public static bool PhoneLength(string phonenum)
        {
            if (phonenum.Length != 11)
            {
                return false;
            }
            return true;

        }
        public static bool GenericLength(string lengthyfella)
        {
            if (lengthyfella.Length > 30)
            {
                return false;
            }
            return true;
        }
    }
}
