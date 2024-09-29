import os

def clear_screen():
    os.system('cls')
clear_screen()


currentBalance = 1000
openingBalance = 1000
previousBalance = 0

# Displaying a selection menu for a banking app
print("Welcome to SEAP-10 Banking App!")
print("1. Check Balance")
print("2. Deposit Money")
print("3. Withdraw Money")
print("4. Exit")

# Get user input for selection
choice = input("Please enter your choice (1-4): ")

# user's selection
if choice == "1":
    print(f"Your current balance is {currentBalance}")
elif choice == "2":
    amount = float(input("Enter the amount to deposit: "))
    currentBalance += amount
    print(f"${amount} deposited successfully.")
    # Update balance logic here
elif choice == "3":
    amount = float(input("Enter the amount to withdraw: "))
    if amount <= currentBalance:
        currentBalance -= amount
        print(f"${amount} withdrawn successfully.")
    else:
        print("Insufficient funds.")
    # Update balance logic here
elif choice == "4":
    print("Thank you for using our banking app. Goodbye!")
else:
    print("Invalid choice. Please select a valid option.")
