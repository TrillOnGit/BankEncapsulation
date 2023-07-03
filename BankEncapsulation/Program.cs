using System.Diagnostics;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();
            
            Console.WriteLine("Type Deposit if you would like to Deposit, Withdraw if you would like to remove balance, or Get if you would like to retrieve your current balance.");
            var userInput = Console.ReadLine();
            switch(userInput.ToLower())
            {
                case "deposit": 
                    Console.WriteLine($"Alright, how much would you like to deposit?");

                    double number = 0;
                    
                    if (double.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine($"You've deposited money successfully!");
                        myAccount.Deposit(number);
                        Console.WriteLine(myAccount.GetBalance());
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    break;
                case "withdraw":
                    if (double.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine($"You've withdrew money successfully!");
                        myAccount.Withdraw(number);
                        Console.WriteLine(myAccount.GetBalance());
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    break;
                case "Get":
                    Console.WriteLine(myAccount.GetBalance());
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
