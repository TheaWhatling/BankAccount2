using System;
using System.Security.Cryptography.X509Certificates;

namespace BankAccount2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string a;
            int b;
            string c;
            int d;


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

                

                a = s[x].getname();
                b = s[x].getbalance();
                c = s[x].getaddress();
                d = s[x].getbankaccountnum();

            }

            
            Console.WriteLine("information: ");
            Console.WriteLine("name: " + a);
            Console.WriteLine("balance: " + b);
            Console.WriteLine("address: " + c);
            Console.WriteLine("bank account number: " + d);

            string answer1;
            Console.WriteLine("would you like to make a withdrawal? yes/no");
            answer1 = Console.ReadLine();
            if (answer1 == "yes")
            {
                int amount1;
                Console.WriteLine("How much?");
                amount1 = Convert.ToInt32(Console.ReadLine());
                s[x].withdraw(amount1);
            }

            Console.WriteLine("your new balance is: " + s[x]getbalance());

            string answer2;
            Console.WriteLine("would you like to make a deposit? yes/no");
            answer2 = Console.ReadLine();
            if (answer2 == "yes")
            {
                int amount2;
                Console.WriteLine("How much?");
                amount2 = Convert.ToInt32(Console.ReadLine());
                s[x].deposit(amount2);
            }

            Console.WriteLine("your new balance is: " + s[x]getdeposit());
        }
    }
}
 