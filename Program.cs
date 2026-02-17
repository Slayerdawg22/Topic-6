using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Security;

namespace Topic_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 for min and max questions");
                Console.WriteLine("2 for bank");
                Console.WriteLine("3 for Die rolls");
                Console.WriteLine("4 for exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MinMax();
                        break;
                    case "2":
                        Bank();
                        break;
                    case "3":
                        Die();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid menu choice.");
                        break;


                }
            }
        }
        public static void MinMax()
        {
            decimal min;
            decimal max;
            decimal numBetween;
            Console.WriteLine("Welcome to the MinMax station");
            Console.WriteLine();
            
            Console.WriteLine("Please enter a min number");
            while (!decimal.TryParse(Console.ReadLine(), out min) || min < 0)
                Console.WriteLine("Invalid Input, please try again");
            Console.WriteLine("Please enter a Max number");
            while (!decimal.TryParse(Console.ReadLine(), out max) || max < 0)
                Console.WriteLine("Invalid Input, please try again");

            //Console.WriteLine($"Now can you enter a number between {min} and {max}");
            //while (!decimal.TryParse(Console.ReadLine(), out numBetween) || numBetween < 0)
            //Console.WriteLine("Invalid Input, please try again");
            do
            {
                Console.WriteLine($"Now can you enter a number between {min} and {max}");
                while (!decimal.TryParse(Console.ReadLine(), out numBetween) || numBetween < 0)
                    Console.WriteLine("Invalid Input, please try again");
                if (numBetween < min || numBetween > max)
                {
                    Console.WriteLine("Incorrect, try again");
                }
            } while (numBetween < min || numBetween > max);
            Console.WriteLine("Good job! You did it!");
            Console.WriteLine();
            Console.WriteLine();





        }
        public static void Bank()
        {
            decimal total = 150;
            decimal depo;
            decimal bill;
            decimal withdrawal;
            bool inBank = true;
            while (inBank)
            {
                Console.Clear();
                Console.WriteLine("WELCOME TO BoB, THE BEST BANK IN THE UNIVERSE");
                Console.WriteLine();
                Console.WriteLine("There are many options such as:");
                Console.WriteLine("Deposit: Enter 1");
                Console.WriteLine("Bill payment: Enter 2");
                Console.WriteLine("Withdrawal: Enter 3");
                Console.WriteLine("Account Balance Update: Enter 4");
                Console.WriteLine("Exit: Enter 5");
                Console.WriteLine($"You have {total:C} to use in this bank");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("To Deposit, enter the amount you'd like to deposit");
                        while (!decimal.TryParse(Console.ReadLine(), out depo) || depo < 0)
                            Console.WriteLine("Invalid Input, please try again");
                        Console.WriteLine();
                        Console.WriteLine($"You are going to deposit {depo:C}");
                        Console.WriteLine("You are still going to be charged $0.75 for this transaction thought");
                        total -= 0.75m;
                        total += depo;
                        Console.WriteLine($"Your total is now {total:C}.");

                        break;
                    case "2":
                        Console.Clear();
                        total -= 0.75m;
                        Console.WriteLine("How much do you want to pay for your bill");
                        while (!decimal.TryParse(Console.ReadLine(), out bill) || bill < 0)
                            Console.WriteLine("Invalid Input, please try again");
                        Console.WriteLine();
                        total -= bill;
                        Console.WriteLine($"You will pay {bill:C}. Your total is now {total:C}.");
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.Clear();
                        total -= 0.75m;
                        Console.WriteLine("How much do you want to withdrawal?");
                        while (!decimal.TryParse(Console.ReadLine(), out withdrawal) || withdrawal < 0)
                            Console.WriteLine("Invalid Input, please try again");
                        total -= withdrawal;
                        Console.WriteLine($"You took out {withdrawal:C}. Your total is now {total:C}.");
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.Clear();
                        total -= 0.75m;
                        Console.WriteLine($"Your account is now at {total:C}");
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.Clear();
                        inBank = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid menu choice.");
                        Console.WriteLine("You will be charged $0.75");
                        total -= 0.75m;
                        break;


                }
                if (inBank)
                {
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                if (total < 0)
                {
                    Console.WriteLine("You are lower then 0 in your account. You now have to leave");
                    return;
                }
            }
        }
        public static void Die()
        {
            Random random = new Random();

            int die1;
            int die2;
            int rollCount = 0;

            do
            {
                Console.Clear();

                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                rollCount++;

                Console.WriteLine($"Roll #{rollCount}");
                Console.WriteLine($"Die 1: {die1}");
                Console.WriteLine($"Die 2: {die2}");

                if (die1 != die2)
                {
                    Console.WriteLine("Press enter to roll again");
                    Console.ReadLine();
                }
            } while (die1 != die2);
            Console.WriteLine($"You got doubles! It took {rollCount} rolls");

                

        }
    
    
    
    }
}
