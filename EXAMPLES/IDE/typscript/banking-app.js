import * as readlineSync from 'readline-sync';

// User registration information
let userName: string;
let userEmail: string;
let initialBalance: number;

// Function to clear the screen
function clearScreen(): void {
    console.clear();
}

// Initial balance for the new user
const openingBalance: number = 1000;
let currentBalance: number = openingBalance;
let previousBalance: number = 0;

// Displaying a selection menu for a banking app
console.log("Welcome to SEAP-10 Banking App!");
console.log("1. Check Balance");
console.log("2. Deposit Money");
console.log("3. Withdraw Money");
console.log("4. Exit");

// Get user input for selection
const choice: string = readlineSync.question("Please enter your choice (1-4): ");

// User's selection
if (choice === "1") {
    console.log(`Your current balance is ${currentBalance}`);
} else if (choice === "2") {
    const amount: number = parseFloat(readlineSync.question("Enter the amount to deposit: "));
    currentBalance += amount;
    console.log(`$${amount} deposited successfully.`);
    // Update balance logic here
} else if (choice === "3") {
    const amount: number = parseFloat(readlineSync.question("Enter the amount to withdraw: "));
    if (amount <= currentBalance) {
        currentBalance -= amount;
        console.log(`$${amount} withdrawn successfully.`);
    } else {
        console.log("Insufficient funds.");
    }
    // Update balance logic here
} else if (choice === "4") {
    console.log("Thank you for using our banking app. Goodbye!");
} else {
    console.log("Invalid choice. Please select a valid option.");
}