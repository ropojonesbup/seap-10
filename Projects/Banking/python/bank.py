print("")
print("")
print("***************")
print("Welcome SEAP-F1")
print("***************")
print("")
print("")


class User() :
    def __init__(self, name, age, gender) :
        self.name = name
        self.age = age
        self.gender = gender
        
    def show_details(self):
        return f"Thank you, {self.age} year old, {self.name.title()}"
    
class Bank(User):
    total_deposits = 0
    total_deposits = 0
    
    def __init__(self, name, age, gender, balance):
        super().__init__(name, age, gender)
        self.balance = balance
        
    def show_info(self):
        return f"{self.name} has a remaining balance of: ${round(self.balance, 2)}"
    
    def deposite(self):
        dp = float(input(f"{self.name.title()}, please enter how much you would like to deposit"))
        print("Thank you for depositing...")
        self.balance += dp
        self.total_deposits += 1
        return f"Your balance is now: {round(self.balance, 2)}"
    
    def withdraws(self):
        wd = float(input(f"{self.name.title()}, please enter how much you would like to deposite"))
        if self.balance < wd:
            return f"You can not withdraw that amount"
        else:
            print("Thank you for withdrawing...")
            self.balance -= wd
            self.total_withdraws += 1
            
def options(user_two):
    print("Thank you for creating your bank account")
    print("Here are the list options, please choose the one you want")
    while True:
        option_choice = int(input("1) See Balance\n2 Withdraw\n3 Deposit\n4 See Total Deposits\n5 See Total Withdraws\n6) Quit\n"))
        if option_choice == 1:
            print(user_one_bank.show_info()) 
            if option_choice == 1 and user_two != None:
                print(user_two_bank.show_info())
            elif option_choice  == 2:
                print(user_one_bank.withdraws())
                if option_choice == 2 and user_two != None:
                    wd = input(f"{user_two.name} would you like to withdraw? Yes or No: ")
                    if wd.lower() == 'yes':
                        print(user_two_bank.withdraws())
            elif option_choice == 3:
                print(user_one_bank.deposit())
                if option_choice == 3 and user_two != None:
                    dep = input(f"{user_two.name} would you like to deposit? Yes or No: ")
                    if dep.lower() == 'yes':
                        print(user_two_bank.deposits())
            elif option_choice == 4:
                print(f"There have been {user_one_bank.total_withdraws} withdraws. ")
                if option_choice == 4 and user_two != None:
                    print(f"There have been {user_two_bank.total_withdraws} withdraws.")
            elif option_choice == 5:
                print(f"There have been {user_one_bank.total_deposits} deposits. ")
                if option_choice == 5 and user_two != None:
                    print(f"There have been {user_two_bank.total_deposits} deposits. ")
            elif option_choice == 6:
                print("Thank you for using SOMKIZZ Bank.")
                return False
            else:
                print("Please choose a number from 1-6. ")
                
def bank_creation(name):
    balance = float(input(f"{name.title()}, how much do you have "))
    return balance

while True:
    print("Welcome to Somkizz Bank")
    name = input("Enter your name")
    age = int(input("Enter your age"))
    gender = (input("Enter your gender"))
    user_one = User(name, age, gender)
    user_two = None
    new_user = input("Would you like to register a new person? Type 'No' to create your bank")
    if new_user.lower() == 'yes':
        name = input("Enter the second person's name: ")
        age = int(input("Enter the second persons's age: "))
        user_two = User(name, age, gender)
        print("Thank you for registering 2 people. please create your bank accounts.")
        user_one_balance = bank_creation(user_one.name)
        user_two_balance = bank_creation(user_one.name)
        user_one_bank = Bank(user_one.name, user_one.age, user_one.gender, user_one_balance)
        user_two_bank = Bank(user_two.name, user_two.age, user_two.gender, user_two_balance)
        flag = options(user_two)
        if flag == False:
            break
    else:
        user_one_balance = bank_creation(user_one.name)
        user_one_bank  = Bank(user_one.name, user_one.age, user_one.gender, user_one_balance)
        flag = options(user_two)
        if flag == False:
            break