using System;
using System.Security.Cryptography.X509Certificates;

namespace BankAccount2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Create a bank account class, attributes should include name, balance, address and bankaccount number.

            //Create get set methods, and withdraw, deposit and print statement to screen message.

            BankAccount[] s = new BankAccount[10];

            for (int x = 0; x < 10; x = x + 1)
            {             

                string enteredname = " ";
                Console.WriteLine("please enter name");
                enteredname = Console.ReadLine();
             

                int enteredbalance = 0;
                Console.WriteLine("please enter balance");
                enteredbalance = Convert.ToInt32(Console.ReadLine());
                

                string enteredaddress = " ";
                Console.WriteLine("please enter your address/city");
                enteredaddress = Console.ReadLine();

               
                s[x] = new BankAccount(enteredname, enteredbalance, enteredaddress);

            }

            string answer1;
            Console.WriteLine("would you like to make a withdrawal? yes/no");
            answer1 = Console.ReadLine();
            if (answer1 == "yes")
            {
                int amount1;
                Console.WriteLine("How much?");
                amount1 = Convert.ToInt32(Console.ReadLine());
                s[x].withdraw(amount1);                           //acountSoFar ?
            }

            Console.WriteLine("your new balance is: " + s[x].getbalance());


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

            Console.WriteLine("your new balance is: " + s[x].getbalance());

            string answer3;
            Console.WriteLine("would you like to see your statement? yes/no");
            answer3 = Console.ReadLine();
            if (answer3 == "yes")
            {
                Console.WriteLine(b.print());
            }
            
        }
    }
}
// In your main code you are using the for loop variable X outside of the for loop you define it in. X only has scope between the for loop brackets it is declared in.
    
