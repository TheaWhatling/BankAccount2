using System;

namespace BankAccount2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            //Create a bank account class, attributes should include name, balance, address and bankaccount number.

            //Create get set methods, and withdraw, deposit and print statement to screen message.

            BankAccount[] s = new BankAccount[10];

            for (int x = 0; x < 10; x = x + 1)
            {
                s[x] = new BankAccount();

                string enteredname = " ";
                Console.WriteLine("please enter name");
                enteredname = Console.ReadLine();
                s[x].setname(enteredname);

                int enteredbalance = 0;
                Console.WriteLine("please enter balance");
                enteredbalance = Convert.ToInt32(Console.ReadLine());
                s[x].setbalance(enteredbalance);

                string enteredaddress = " ";
                Console.WriteLine("please enter your address/city");
                enteredaddress = Console.ReadLine();
                s[x].setaddress(enteredaddress);

                int enteredbankaccountnum = 0;
                Console.WriteLine("please enter your bankaccount number");
                enteredbankaccountnum = Convert.ToInt32(Console.ReadLine());
                s[x].setbankaccountnum(enteredbankaccountnum);

                t = x;

            }

            Console.WriteLine("information: ");
            Console.WriteLine("name: " + s[t]getname);
            Console.WriteLine("balance: " + s[t]getbalance);
            Console.WriteLine("address: " + s[t]getaddress);
            Console.WriteLine("bank account number: " + s[t]getbankaccountnum);

            //Console.WriteLine(s[t].print());

            //int hoursinput = 0;
            //Console.WriteLine("enter the number of hours " + s[x].getName() + " has worked"); // change so v can change 
            //hoursinput = Convert.ToInt32(Console.ReadLine());
            //s[x].learn(hoursinput);


        }
    }
}
 