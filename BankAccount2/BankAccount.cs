using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount2
{
    class BankAccount
    {

        private string name;
        private int balance;
        private string address;
        private int bankaccountnum;
        private static int accountsSoFar = 0;

        public BankAccount()
        {
            name = "test";
            balance = 0;
            address = "London";
            bankaccountnum = accountsSoFar;
            accountsSoFar ++;
        }

        public BankAccount(string name)
        {
            this.name = name;
            this.balance = 0;
            this.address = "London";
            this.bankaccountnum = accountsSoFar;
            accountsSoFar ++;
        }

        public BankAccount(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
            this.address = "London";
            this.bankaccountnum = accountsSoFar;
            accountsSoFar ++;
        }

        public BankAccount(string name, int balance, string address)
        {
            this.name = name;
            this.balance = balance;
            this.address = address;
            this.bankaccountnum = 0;
            accountsSoFar ++;
        }


        public static void accountsSorFar(int v)
        {
            accountsSoFar = v;
        }

        public void setname(string name) 
        {
            this.name = name;
        }

        public string getname()
        {
            return name;
        }

        public void setbalance(int balance)
        {
            this.balance = balance;
        }

        public int getbalance()
        {
            return balance;
        }

        public void setaddress(string address)
        {
            this.address = address;
        }

        public string getaddress()
        {
            return address;
        }

        public void setbankaccountnum(int bankaccountnum)
        {
            this.bankaccountnum = bankaccountnum;
        }

        public int getbankaccountnum()
        {
            return bankaccountnum;
        }

        public void deposit(int amount2)
        {
            if (amount2 <= 0)
            {
                Console.WriteLine("Amount of deposit must be positive");
            }
            else balance = balance + amount2;
            
        }
      
        public void withdraw(int amount1) 
        {
            if (amount1 <= 0)
            {
                Console.WriteLine("Amount of withdrawal must be positive");
            }
            if (balance - amount1 < 0)
            {
                Console.WriteLine("Not sufficient funds for this withdrawal");
            }
            else balance = balance - amount1;
            
        }

        public void print()
        {
            Console.WriteLine("information: ");
            Console.WriteLine("name: " + name);
            Console.WriteLine("balance: " + balance);
            Console.WriteLine("address: " + address);
            Console.WriteLine("bank account number: " + bankaccountnum);
        }
    }
}
