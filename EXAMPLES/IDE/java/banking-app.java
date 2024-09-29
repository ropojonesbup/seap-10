import java.util.Scanner;

public class BankingApp {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        // Displaying a selection menu for a banking app
        System.out.println("Welcome to Our Banking App!");
        System.out.println("1. Check Balance");
        System.out.println("2. Deposit Money");
        System.out.println("3. Withdraw Money");
        System.out.println("4. Exit");
        
        // Get user input for selection
        System.out.print("Please enter your choice (1-4): ");
        int choice = input.nextInt();
        
        // Process the user's selection
        switch (choice) {
            case 1:
                System.out.println("Your current balance is 1000");
                break;
            case 2:
                System.out.print("Enter the amount to deposit: ");
                double amount = input.nextDouble();
                System.out.println("$" + amount + " deposited successfully.");
                // Update balance logic here
                break;
            case 3:
                System.out.print("Enter the amount to withdraw: ");
                double withdrawAmount = input.nextDouble();
                System.out.println("$" + withdrawAmount + " withdrawn successfully.");
                // Update balance logic here
                break;
            case 4:
                System.out.println("Thank you for using our banking app. Goodbye!");
                break;
            default:
                System.out.println("Invalid choice. Please select a valid option.");
        }
    }
}