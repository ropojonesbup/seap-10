// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.InteropServices;

string firstname;
string lastname;
int nin;
string phone;
int bvn;
string email;
string gender;


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("***************");
Console.WriteLine("Welcome SEAP-F1");
Console.WriteLine("***************");
Console.WriteLine("");
Console.WriteLine("Nigeria's best mobile banking platform.");
Console.WriteLine("");
Console.WriteLine("Please select an option:");
Console.WriteLine("");
Console.WriteLine("1. Customer Onboarding");
Console.WriteLine("2. Account Opening");
Console.WriteLine("3. Deposit to Account");
Console.WriteLine("4. Withdrawal from Account");
Console.WriteLine("5. Transfer to other Accounts");
Console.WriteLine("6. Account Closing");
Console.WriteLine("7. View all Transaction");
Console.WriteLine("");
Console.Beep();
Console.Beep();
Console.Beep();


Console.Beep();
Console.WriteLine("Option: ");
Option = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (option -- 1)
{   
    Console.WriteLine("Customer Onboarding: ");
    Console.WriteLine("---------------------");
    Console.WriteLine("");
    Console.WriteLine ("Please enter customer information");

    Console.Beep();
    Console.WriteLine("Firstname: ");
    firstname = Console.ReadLine();
    Console.WriteLine("");

    Console.Beep();
    Console.WriteLine("Lastname: ");
    lastname = Console.ReadLine();
    Console.WriteLine("");

    Console.Beep();
    Console.WriteLine("Gender: ");
    gender = Console.ReadLine();

    Console.Beep();
    Console.WriteLine("BVN: ");
    bvn = int.Parse(Console.ReadLine());

    Console.Beep();
    Console.WriteLine("");

    Console.WriteLine("NIN: ");
    nin = int.Parse(Console.ReadLine());

    Console.WriteLine("Email: ");
    email = Console.ReadLine();

    Console.Beep();
    Console.WriteLine("Phone: ");
    phone = Console.ReadLine();
    Console.WriteLine("");

    
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





}
