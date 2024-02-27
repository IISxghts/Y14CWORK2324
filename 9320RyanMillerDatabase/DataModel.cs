using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9320RyanMillerDatabase
{
    public class DataModel
    {
        public static string DisplayUname;
        public static string UserType;
        public static string ViewOption;
        
        
        public static bool Brightness(bool bright)
        {
            if (bright == false)
            {
                return false;
            }
            return true;
        }

    }
}
