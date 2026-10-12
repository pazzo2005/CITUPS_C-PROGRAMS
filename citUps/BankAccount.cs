using System;
using System.Collections.Generic;
using System.Text;

namespace citUps
{
    public class BankAccount
    {
        public string Name { get; private set; }
        public long AccountNumber { get; private set; }
        public double BalanceAmount { get; private set; }
     
        
        public BankAccount(string name,long accountNumber,double balanaceAmount)
        {
            Name = name;
            AccountNumber = accountNumber;
            BalanceAmount = balanaceAmount;
        }
        static List<BankAccount> bankAccounts = new List<BankAccount>();
        public string  CreateAccount(string name,long accountNumber,double balanceAmount)
        {
            try
            {
                BankAccount account = new BankAccount(name, accountNumber, balanceAmount);
                bankAccounts.Add(account);

            }catch(Exception e)
            {
                Console.WriteLine("Error creating account:" + e.Message);
            }
            return "Account created Successfully";

        }
        public string DeleteAccount(long Number)
        {
            try
            {
                BankAccount account = bankAccounts.Find(a => a.AccountNumber == Number);
                if (account != null)
                {
                    bankAccounts.Remove(account);
                    return "Account deleted successfully";
                }
                return "Account does not exist";

            }
            catch(Exception e)
            {
                return "Error in deleteing the account" + e.Message;
            }
        }
        public void AddBalance(double amount)
        {

        }
        public string Deposit(long number , double amount)
        {
            try
            {
                BankAccount account = bankAccounts.Find(a => a.AccountNumber == number);
                if (account != null)
                {
                    account.BalanceAmount += amount;
                    return "Deposit successfully";
                }
                return "Account does not exist";

            }
            catch(Exception e)
            {
                return "Error in deposit" + e.Message;
            }
        }
        public string WithDraw(long number , double amount)
        {
            try
            {
                BankAccount account = bankAccounts.Find(a => a.AccountNumber == number);
                if (account != null)
                {
                    if(account.BalanceAmount==0 || account.BalanceAmount < amount)
                    {
                        return "Insufficient Balance";
                    }
                    account.BalanceAmount -= amount;
                    return "withdraw successfully";
                }
                return "account does not exist";
            }catch(Exception e)
            {
                return "Error in withdraw" + e.Message;
            }
        }
    }
}
