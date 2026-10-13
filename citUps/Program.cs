using System;
using System.Diagnostics.CodeAnalysis;

namespace citUps
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount bank = new BankAccount("aditya",789,65);
            bank.Service();

        }
    }
}
