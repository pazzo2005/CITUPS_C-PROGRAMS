using System;
using System.Collections.Generic;
using System.Text;

namespace citUps
{
    internal class leapYear
    {
        public void CheckYr(int yr)
        {
            if(yr%4==0 || yr % 100 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("NOT A LEAP YEAR");
            }
        }
    }
}
