
// type variableName = value;


string firstname;
string lastname;
int nin;
int bvn;
string phone;
string email;
string gender;
int option;

Console.Clear();
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("***************");
Console.WriteLine("Welcome SEAP-FI");
Console.WriteLine("***************");
Console.WriteLine("");
Console.Beep();
Console.Beep();
Console.Beep();

Console.WriteLine("1. Customer Onboarding");
Console.WriteLine("2. Account Opening");
Console.WriteLine("3. Deposit to Account");
Console.WriteLine("4. Withdrawal from Account");
Console.WriteLine("5. Transfer to other Accounts");
Console.WriteLine("6. Account Closing");
Console.WriteLine("7. View all Transaction");
Console.WriteLine("8. Exit Application");
Console.WriteLine("");

Console.Beep();
Console.Write("Option: ");
option = int.Parse(Console.ReadLine());
Console.WriteLine("");
//test
if (option == 1)
{
    Console.Beep();
    Console.WriteLine("Customer Onboarding");
    Console.WriteLine("-------------------");
    Console.WriteLine("");
    Console.WriteLine("Please enter information");
    Console.WriteLine("");

    Console.Beep();
    Console.Write("Firstname: ");
    firstname = Console.ReadLine();
    Console.WriteLine("");

    Console.Beep();
    Console.Write("Lastname: ");
    lastname = Console.ReadLine();
    Console.WriteLine("");

    Console.Beep();
    Console.Write("Gender (M or F):  ");
    gender = Console.ReadLine();
    Console.WriteLine("");

    Console.Beep();
    Console.Write("BVN: ");
    bvn = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.Beep();
    Console.Write("NIN: ");
    nin = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.Beep();
    Console.Write("Email: ");
    email = Console.ReadLine();
    Console.WriteLine("");

    Console.Beep();
    Console.Write("Phone: ");
    phone = Console.ReadLine();
    Console.WriteLine("");


    Console.Beep();
    Console.WriteLine("Customer registration was successful.");
    Console.WriteLine("");
    Console.WriteLine("Firstname: {0}", firstname);
    Console.WriteLine("Lastname: {0}", lastname);
    Console.WriteLine("Gender: {0}", gender);
    Console.WriteLine("BVN: {0}", bvn);
    Console.WriteLine("NIN: {0}", nin);
    Console.WriteLine("Phone: {0}", phone);
    Console.WriteLine("Email: {0}", email);
    Console.Beep();
    Console.WriteLine("");
    Console.WriteLine("");

}
if (option == 2){
    
    Console.Beep();
    Console.WriteLine("Account Opening");
    Console.WriteLine("-------------------");
    Console.WriteLine("");
     // .............
}
if (option == 3){
   
    Console.Beep();
    Console.WriteLine("Deposit");
    Console.WriteLine("-------------------");
    Console.WriteLine("");
    // .............
}
if (option == 4){
    Console.Beep();
    Console.WriteLine("Withdrawal");
    Console.WriteLine("-------------------");
    Console.WriteLine("");
    // .............
}

