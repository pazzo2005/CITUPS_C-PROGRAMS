using System;
using System.Diagnostics.CodeAnalysis;

namespace citUps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            for(int i = 0; i < 2; ++i) {
                string name = "";
                long accountNumber = 0;
                double amount = 0;
                ++no;
                for (int j = 0; j < 3; ++j)
                {
                    
                    Console.Write("Enter the account1 Name:");
                    name = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter the account" + no + "Number:");
                    if(long.TryParse(Console.ReadLine(),out   accountNumber)){
                        Console.WriteLine("Account number" + accountNumber);
                    }
                    Console.Write("Enter the amount");
                    amount = Convert.ToDouble(Console.ReadLine());
                    
                }
                BankAccount account =new BankAccount(name, accountNumber, amount);
            }


        }
    }
}
