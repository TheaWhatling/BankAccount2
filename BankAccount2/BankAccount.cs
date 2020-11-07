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

        public BankAccount()
        {
            name = "test";
            balance = 0;
            address = "London";
            bankaccountnum = 0;
        }

        public BankAccount(string name)
        {
            this.name = name;
            this.balance = 0;
            this.address = "London";
            this.bankaccountnum = 0;
        }

        public BankAccount(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
            this.address = "London";
            this.bankaccountnum = 0;
        }

        public BankAccount(string name, int balance, string address)
        {
            this.name = name;
            this.balance = balance;
            this.address = address;
            this.bankaccountnum = 0;
        }

        public BankAccount(string name, int balance, string address, int bankaccountnum)
        {
            this.name = name;
            this.balance = balance;
            this.address = address;
            this.bankaccountnum = bankaccountnum;
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

        //public void print(string name, int balance, string address, int bankaccountnum)
        //{
        //    Console.WriteLine("name: " + name);
        //    Console.WriteLine("balance: " + balance);
        //    Console.WriteLine("address: " + address);
        //    Console.WriteLine("bank account number: " + bankaccountnum);
        //}




    }
}
