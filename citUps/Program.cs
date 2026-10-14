using System;
using System.Diagnostics.CodeAnalysis;

namespace citUps
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            ParkingSystemManager park = new ParkingSystemManager('A',true);
            park.ParkingService();

        }
    }
}
