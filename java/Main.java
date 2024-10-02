import java.util.Scanner;

/**
 * Build a core banking platform in console
 * 
 * Features:
 * - Customer onboarding
 * - Account opening
 * - Deposit to account
 * - Transfer to other accounts
 * - Account closing
 * - View all transactions
 * - Exit application
 */

public class Main {
    private static double balance = 0.0;

    public static void main(String[] args) {
        Scanner userInput = new Scanner(System.in);
        boolean running = true;

        while (running) {
            clearConsole();
            System.out.println("*********************");
            System.out.println("Welcome to SEAP-FI");
            System.out.println("*********************");
            System.out.println(" ");
            welcome();

            String response = userInput.next();

            switch (response) {
                case "1":
                    System.out.println("Welcome, We are here to serve you.");
                    break;
                case "2":
                    openAccount(userInput);
                    break;
                case "3":
                    deposit(userInput);
                    break;
                case "4":
                    transfer(userInput);
                    break;
                case "5":
                    freeze(userInput);
                    break;
                case "6":
                    transaction(userInput);
                    break;
                case "7":
                    System.out.println("Exiting the application. Thank you!");
                    running = false;
                    break;
                default:
                    System.out.println("Invalid option selected. Please try again.");
                    break;
            }
            if (running) {
                pauseBeforeContinuing();
            }
        }

        userInput.close();
    }

    public static void welcome() {
        System.out.println("Please select an option:");
        System.out.println("1. Customer onboarding");
        System.out.println("2. Account opening");
        System.out.println("3. Deposit to account");
        System.out.println("4. Transfer to other accounts");
        System.out.println("5. Account closing");
        System.out.println("6. View all transactions");
        System.out.println("7. Exit application");
        System.out.println(" ");
        System.out.println("Nigerian's best mobile banking platform");
    }

    public static void openAccount(Scanner userInput) {
        System.out.println("What is your name?");
        String name = userInput.next();

        System.out.println("Select account type:");
        System.out.println("1. Current");
        System.out.println("2. Savings");

        String accountType = userInput.next();
        String accountTypeName = accountType.equals("1") ? "Current" : "Savings";

        int accountNumber = (int) (Math.random() * 1000000000);

        System.out.println("Account successfully created!!");
        System.out.println("Name: " + name);
        System.out.println("Account type: " + accountTypeName);
        System.out.printf("Current balance: %.2f\n", balance);
        System.out.println("Your account number is " + accountNumber + ". Kindly take note.");
    }

    public static void deposit(Scanner userInput) {
        System.out.println("How much would you like to deposit?");
        double depositAmount = userInput.nextDouble();

        balance += depositAmount;

        System.out.printf("Deposit successful! Your new balance is: %.2f\n", balance);
    }

    public static void transfer(Scanner userInput) {
        System.out.println("Which bank are you transferring to?");
        String bankName = userInput.next();
        System.out.println("Receipent Account number?");
        int bankaccountNumber = userInput.nextInt();

        System.out.println("How much would you like to transfer?");
        double transferAmount = userInput.nextDouble();

        balance -= transferAmount;

        System.out.printf("Your transfer to " + bankaccountNumber + " , " + bankName + "is successfull" );
    }


    public static void transaction(Scanner userInput) {
        System.out.println("This is your statement of account ");
        System.out.println("Thanks for always banking with us");
    }

    public static void freeze(Scanner userInput) {
        System.out.println("you account has been freezed");
        System.out.println("Kindly contact the customer care for more details");
        System.out.println("Thanks");
    }

    public static void clearConsole() {
        System.out.print("\033[H\033[2J");
        System.out.flush();
    }
    public static void pauseBeforeContinuing() {
        System.out.println("Press enter to continue...");
        try {
            System.in.read();
        } catch (Exception e) {
        }
    }
}
