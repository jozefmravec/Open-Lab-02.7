using System;
using System.Collections.Generic;
using System.Text;

namespace OpenLab2._7a
{
    class Christmas
    {
        public bool IsTimeForCookies(int month, int day)
        {
            if (month == 12 && day == 24)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    } 
}
