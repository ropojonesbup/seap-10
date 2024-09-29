using System;

class Program
{
    static void Main()
    {
        string name;
        string email;
        double initialBalance;

        Console.WriteLine("Welcome to SEAP-10 Banking App!");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Register New User");
        Console.WriteLine("5. Exit");

        Console.Write("Please enter your choice (1-5): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine($"Your current balance is {currentBalance}");
                break;
            case "2":
                Console.Write("Enter the amount to deposit: ");
                double depositAmount = Convert.ToDouble(Console.ReadLine());
                currentBalance += depositAmount;
                Console.WriteLine($"${depositAmount} deposited successfully.");
                // Update balance logic here
                break;
            case "3":
                Console.Write("Enter the amount to withdraw: ");
                double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                if (withdrawAmount <= currentBalance)
                {
                    currentBalance -= withdrawAmount;
                    Console.WriteLine($"${withdrawAmount} withdrawn successfully.");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
                // Update balance logic here
                break;
            case "4":
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                Console.Write("Enter your email: ");
                email = Console.ReadLine();
                Console.Write("Enter initial balance: ");
                initialBalance = Convert.ToDouble(Console.ReadLine());
                // Add logic to register new user with the provided information
                break;
            case "5":
                Console.WriteLine("Thank you for using our banking app. Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}