using System;

namespace SEAPFi
{
    class Banking
    {
        // Main method where the program starts execution
        static void Main(string[] args)
        {
            // Declaring variables to simulate customer, account, and transaction details
            string customerName = "John Doe"; // Variable to store the customer’s name
            string accountNumber = "123456789"; // Variable to store the account number
            decimal openingBalance = 1000m; // 'm' is used to define a decimal literal, indicating the initial account balance
            decimal currentBalance = openingBalance; // Initially, the current balance is the same as the opening balance
            decimal previousBalance = 0; // Variable to store the previous balance before any transactions

            // Displaying the menu and options for the banking system
            Console.WriteLine("*********\n\nWELCOME to SEAP-Fi\n\n********"); // Displaying a welcome message
            Console.WriteLine("Nigeria's best mobile banking platform."); // Displaying a description of the banking platform
            Console.WriteLine(); // Blank line for spacing
            Console.WriteLine("-------------------------------------"); // Separator for readability
            Console.WriteLine(); // Blank line for spacing

            // Main loop to keep the application running until the user decides to exit
            while (true)
            {
                // Displaying options for the user
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Customer Onboarding"); // Option 1: Onboard a customer
                Console.WriteLine("2. Account Opening"); // Option 2: Open a bank account
                Console.WriteLine("3. Deposit to Account"); // Option 3: Deposit money into the account
                Console.WriteLine("4. Withdrawal from Account"); // Option 4: Withdraw money from the account
                Console.WriteLine("5. Transfer to Other Accounts"); // Option 5: Transfer money to another account
                Console.WriteLine("6. View all Transactions"); // Option 6: View past transactions
                Console.WriteLine("\nEnter your choice (7 to Exit):"); // Option 7: Exit the application

                // Taking user input and converting it to an integer
                string inputChoice = Console.ReadLine(); // Reading user input as a string
                int choice; // Declaring an integer variable to hold the parsed choice

                // Attempting to parse the user input; if parsing fails, defaulting to an invalid choice
                if (string.IsNullOrEmpty(inputChoice) || !int.TryParse(inputChoice, out choice))
                {
                    choice = -1; // Assigning an invalid choice
                }

                // Logic to handle user's choice using if-else statements
                if (choice == 1)
                {
                    // Customer Onboarding
                    Console.WriteLine("\nCustomer Onboarding Completed.");
                    Console.WriteLine($"Customer Name: {customerName}"); // Displaying the customer name (preset value)
                }
                else if (choice == 2)
                {
                    // Account Opening
                    Console.WriteLine("\nAccount Opening Successful.");
                    Console.WriteLine($"Account Number: {accountNumber}"); // Displaying the account number (preset value)
                    Console.WriteLine($"Opening Balance: {openingBalance}"); // Displaying the opening balance
                }
                else if (choice == 3)
                {
                    // Deposit to Account
                    Console.Write("\nEnter deposit amount: ");
                    string inputDepositAmount = Console.ReadLine(); // Reading the deposit amount as a string
                    decimal depositAmount; // Declaring a variable for the deposit amount

                    // Attempting to parse the deposit amount; if parsing fails, defaulting to an invalid amount
                    if (string.IsNullOrEmpty(inputDepositAmount) || !decimal.TryParse(inputDepositAmount, out depositAmount))
                    {
                        depositAmount = -1; // Assigning an invalid amount
                    }

                    if (depositAmount > 0)
                    {
                        previousBalance = currentBalance; // Setting the previous balance before updating it
                        currentBalance += depositAmount; // Adding deposit to current balance
                        Console.WriteLine($"\nDeposit Successful. New Balance: {currentBalance}"); // Displaying the new balance after deposit
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Deposit Amount."); // Error message for invalid deposit amount
                    }
                }
                else if (choice == 4)
                {
                    // Withdrawal from Account
                    Console.Write("\nEnter withdrawal amount: ");
                    string inputWithdrawalAmount = Console.ReadLine(); // Reading the withdrawal amount as a string
                    decimal withdrawalAmount; // Declaring a variable for the withdrawal amount

                    // Attempting to parse the withdrawal amount; if parsing fails, defaulting to an invalid amount
                    if (string.IsNullOrEmpty(inputWithdrawalAmount) || !decimal.TryParse(inputWithdrawalAmount, out withdrawalAmount))
                    {
                        withdrawalAmount = -1; // Assigning an invalid amount
                    }

                    // Checking if the withdrawal amount is valid and if there are sufficient funds
                    if (withdrawalAmount > 0 && withdrawalAmount <= currentBalance)
                    {
                        previousBalance = currentBalance; // Saving the current balance before withdrawal
                        currentBalance -= withdrawalAmount; // Subtracting the withdrawal amount from the balance
                        Console.WriteLine($"\nWithdrawal Successful. New Balance: {currentBalance}"); // Displaying the new balance
                    }
                    else if (withdrawalAmount > currentBalance)
                    {
                        Console.WriteLine("\nInsufficient Funds."); // Error message if the withdrawal amount exceeds the current balance
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Withdrawal Amount."); // Error message for invalid withdrawal amount
                    }
                }
                else if (choice == 5)
                {
                    // Transfer to Other Accounts
                    Console.Write("\nEnter transfer amount: ");
                    string inputTransferAmount = Console.ReadLine(); // Reading the transfer amount as a string
                    decimal transferAmount; // Declaring a variable for the transfer amount

                    // Attempting to parse the transfer amount; if parsing fails, defaulting to an invalid amount
                    if (string.IsNullOrEmpty(inputTransferAmount) || !decimal.TryParse(inputTransferAmount, out transferAmount))
                    {
                        transferAmount = -1; // Assigning an invalid amount
                    }

                    // Checking if the transfer amount is valid and if there are sufficient funds
                    if (transferAmount > 0 && transferAmount <= currentBalance)
                    {
                        previousBalance = currentBalance; // Saving the current balance before transfer
                        currentBalance -= transferAmount; // Subtracting the transfer amount from the balance
                        Console.WriteLine($"\nTransfer Successful. New Balance: {currentBalance}"); // Displaying the new balance after the transfer
                    }
                    else if (transferAmount > currentBalance)
                    {
                        Console.WriteLine("\nInsufficient Funds."); // Error message if the transfer amount exceeds the current balance
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Transfer Amount."); // Error message for invalid transfer amount
                    }
                }
                else if (choice == 6)
                {
                    // View all Transactions
                    Console.WriteLine($"\nOpening Balance: {openingBalance}"); // Displaying the opening balance
                    Console.WriteLine($"Previous Balance: {previousBalance}"); // Displaying the previous balance (before the last transaction)
                    Console.WriteLine($"Current Balance: {currentBalance}"); // Displaying the current balance after all transactions
                }
                else if (choice == 7)
                {
                    // Exiting the program
                    Console.WriteLine("\nExiting... Thank you for using SEAP-Fi."); // Exit message
                    break; // Break the loop to exit the application
                }
                else
                {
                    // Handling invalid choices
                    Console.WriteLine("\nInvalid choice. Please try again."); // Error message for invalid choices
                }
            }

            // End of program, waiting for user input to close the console
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey(); // Wait for the user to press a key before exiting
        }
    }
}
