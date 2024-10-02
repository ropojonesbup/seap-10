def display_menu():
 print ("")
 print ("")
 print ("***************")
 print ("Welcome SEAP-FI")
 print ("***************")
 print ("")
 print ("Nigeria's best mobile platform")
 print ("")
 print ("")
 print ("Main menu")
 print ("")
 print ("1. Customer Onboarding")
 print ("")
 print ("2. Account Opening")
 print ("")
 print ("3. Deposit money") 
 print ("")
 print ("4. Withdraw money")
 print ("")
 print ("5. Transfer money")
 print ("")
 print ("6. Account closing")
 print ("")
 print ("7. View all Transaction")
 print ("")
 print ("8. Exit")
 print ("")
 print ("")

 option = input ("Please select an option: ")
 if option == "1":
       customer_onboarding()
 elif option == "2":
       account_opening()
 elif option == "3":
       deposit_money()
 elif option == "8":
       print("Exiting...")
 else:
       invalid_option()

def customer_onboarding():
     import os
     os.system("cls")
     print("")
     print("Welcome to our bank; the best bank in Nigeria. We are here to serve you.")
     print("")
     print("Go back to the Main Menu")
     print("")

     option = input("Please select 0 to go back to the Main Menu: ")
     if option == "0":
           print("Returning to the Main Menu...")
           display_menu()
     else:
           print ("Invalid option. Please try again.")  

def account_opening():
      import os
      os.system("cls")
      print("")
      print("1. Firstname:")
      print("")         
      print("2. Surname:") 
      print("")        
      print("3. Email address:") 
      print("")        
      print("4. Phone number:")
      print("")
      print("5. Go back to the Main Menu: ")  
      print("")

      option = input("Please select 5 to go back to the Main Menu: ")   
      if option =="5":
            print("Returning to the Main Menu...")
            display_menu()
      else:
            print ("Invalid option. Please try again.") 

   
def deposit_money():
      import os
      os.system("cls")
      print("")
      print("1. Enter account number of recipient:") 
      print("")        
      print("2. Enter amount to send:")
      print("")         
      print("3. Enter bank name of the recipient :")
      print("")         
      print("4. Go back to the Main Menu: ")
      print("")

      option = input("Please select 4 to go back to the Main Menu: ")   
      if option =="4":
            print("Returning to the Main Menu...")
            display_menu()
      else:
            print ("Invalid option. Please try again.") 

def invalid_option():
      import os
      os.system("cls")
      print("")
      print("Invalid Option") 
      print("")                 
      print("Press 2 to go back to the Main Menu: ")
      print("")

      option = input("Please select 2 to go back to the Main Menu: ")   
      if option =="2":
            print("Returning to the Main Menu...")
            display_menu()
      else:
            print ("Invalid option. Please try again.") 
      
      
display_menu()




# def option_selection():
#     # while True:
#         option = input("Please select an option: ")
#         if option == "1":
#                 import os
#                 os.system("cls")
#                 print("1. Firstname")
#                 print("2. Firstname")
#                 print("3. Firstname")     
#         elif option == "2":
#                 print("1. Old balance")
#                 print("2. Current balance")
#                 import os
#                 os.system("cls")
# option_selection()