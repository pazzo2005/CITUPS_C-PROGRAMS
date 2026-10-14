using System;
using System.Collections.Generic;
using System.Text;

namespace citUps
{
    public class BankAccount {
        private string name;
        private long accountNumber;
        private decimal amount;
        public BankAccount(string name , long accountNumber , decimal amount)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.amount = amount;
        }
        static List<BankAccount> accounts = new List<BankAccount>();
       
        public void CreateAccount()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your account number: ");
            long accountNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter your initial deposit amount:  ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            BankAccount account = new BankAccount(name, accountNumber, amount);
            accounts.Add(account);
            Console.WriteLine("Account created successfully ");
        }
        public void Deposit()
        {
            Console.Write("Enter your account number: ");
            long accountNumber =Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the amount u want to deposit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            BankAccount account = accounts.Find(a => a.accountNumber == accountNumber);
            if (account != null) 
            {
                if(amount <= 0)
                {
                    Console.WriteLine("Amount cannot be less than or equal to zero");
                    return;
                }
                else
                {
                    account.amount += amount;
                    Console.WriteLine("Deposit successfully");
                    return;
                }
            }
            else
            {
                Console.Write("Account not found");
                return;
            }
            
        }
        public void WithDraw()
        {
            Console.Write("Enter your account number: ");
            long accountNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the amount u want to withdraw: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            BankAccount account = accounts.Find(a => a.accountNumber == accountNumber);
            if(account.amount==0 || account.amount<amount)
            {
                Console.WriteLine("insufficient");
                return;
            }
            if (account != null )

            {
                
                if (amount <= 0)
                {
                    Console.WriteLine("Insufficient balance");
                    return;
                }
                else
                {
                    account.amount -= amount;
                    if (account.amount < 0) account.amount = 0;

                    Console.WriteLine("Amount withdrwan successfully");
                    return;
                }
            }
            else
            {
                Console.Write("Account not found:");
                return;
            }

        }

        public void Balances()
        {
            Console.Write("Enter your account number: ");
            long accountNumber = Convert.ToInt64(Console.ReadLine());
            BankAccount account = accounts.Find(a => a.accountNumber == accountNumber);
            if (account != null)
            {
                if (account.amount < 0)
                {
                    account.amount = 0;
                    Console.WriteLine("Zero Balance");
                    return;
                }
                Console.WriteLine(account.amount);
                return;
            }
            else
            {
                Console.Write("Account not found ");
            }
        }
         public   void  Service()
        {
            while (true)
            {
                Console.WriteLine("Choose the service: 1.)Account creation 2.)Deposit 3.)Withdraw 4.)Check Balance");
                int service = Convert.ToInt32(Console.ReadLine());
                switch (service)
                {
                    case 1:
                        CreateAccount();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        WithDraw();
                        break;
                    case 4:
                        Balances();
                        break;
                    case 5:
                        Console.WriteLine("Thank u for using our bank application!");
                        return;
                    default:
                        Console.Write("no service available");
                        break;
                }
            }
        }

           
        }

    }
    
       
    

