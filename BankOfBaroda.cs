using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//Duration: 45 Min: Subject: .Net
//Q1.Create Console Appplication for Bank Of Baroda.
//Create a  abstract class Account having member
//a. Id [Let your application generate id, it is readonly]
//b.Name[write getter, setter Method Give Validation Length of  name can not be less then 2 and greater then 15]
//c.Balance[write getter, setter, you can not set value  outside class other than child class]
//It has two methods
//1. public abstract withdraw(double amt);
//2. public void Deposit(double amt) { }
//This method will increase amount in balance.
//Create two child class SavingAccount and CurrentAccount.
//In CurrentAccount user can have negative balance.
//In SavingAccount minimum balance of 1000 need to maintain. Declare const double  minbala=1000
//When use withdraw money they should get SMS and EMAIL about new balance and amount withdrawn.
// When you run application it should display name of bank. 
//Create List of Account class and store child Object.
//Do transaction and ensure user can not withdraw more then the balance. Also ensure it maintain minimum
//balance of 1000 in Saving Account.

//In SavingAccount write public static double Payinterest(Employee e) this method will return interest
//amount  and increase the balance  If data is in-validation then your application should throw
//exception

// Your application should allow you to create only 5 object.
//Your application should handle all exception.
//Write user Define Exception for insufficient balance[If user try to withdraw more then
//minbalance in Saving Account] This class will print user name and transaction detail in a file.

//In Account class Create event. When use withdraw money it should send SMS and E-mail [Complete
//Publisher subscriber design pattern]



namespace BankApplication
{
	public class BankOfBaroda
	{

		static int id;
		static string name;
		static double balance;
		static double interestRate;

		static List<Account> accounts = new List<Account>();
		static BankOfBaroda()
		{
			Console.WriteLine("Bank Of Baroda");
		}

		public static void OpenSavingAccount(int id, string name, double balance )
		{
			accounts.Add(new SavingAccount(id, name, balance));
			Console.WriteLine(string.Format($"you opened the saving account with these details {accounts.Last()} "));	
		}
		public static void OpenCurrentAccount(int id, string name , double balance )
		{
			accounts.Add(new CurrentAccount( id, name , balance));
			Console.WriteLine(string.Format($"you opened the Current account with these details {accounts.Last()} "));
		}

		static void Main(string[] args)
		{
			


			

			
			while(true)
			{
				Console.WriteLine("Enter your options");
				Console.WriteLine("1: To open your Bank Account");
				Console.WriteLine("2: to check you Balance");
				Console.WriteLine("3: To Wthdraw money");
				Console.WriteLine("4: To Deposite money");
				Console.WriteLine("5: To Exit ");

				switch (Convert.ToInt32(Console.ReadLine()))
				{
					case 1:
						{
							Console.WriteLine("enter your choice which type of account you want to open");
							Console.WriteLine("1. for Saving Account ");
							Console.WriteLine("2. for Current Account");
							Console.WriteLine("3. To Get back in Main Menu");
							switch (Convert.ToInt32(Console.ReadLine()))
							{
								case 1:
									{
										Console.WriteLine("please enter the details to open Saving Account");
										Console.Write("\n\n Please Enter Your Name :");
										name = Console.ReadLine();
										Console.Write("\n\n Please Choose Your id (all numeric):");
										id = Convert.ToInt32(Console.ReadLine());
										Console.Write("\n\n Please add Balance in Your account:");
										balance = Convert.ToDouble(Console.ReadLine());
										Console.WriteLine("\n\n please enter the intrest rate given by the bank");
										interestRate = Convert.ToDouble(Console.ReadLine());
										OpenSavingAccount(id, name, balance);
										break;
									}
								case 2:
									{
										Console.WriteLine("please enter the details to open Current Account");
										Console.Write("\n\n Please Enter Your Name :");
										name = Console.ReadLine();
										Console.Write("\n\n Please Choose Your id (all numeric):");
										id = Convert.ToInt32(Console.ReadLine());
										Console.Write("\n\n Please add Balance in Your account:");
										balance = Convert.ToDouble(Console.ReadLine());
										Console.WriteLine("\n\n please enter the intrest rate given by the bank");
										interestRate = Convert.ToDouble(Console.ReadLine());
										OpenCurrentAccount(id, name, balance);
										break;
									}
								case 3:
									{

										break;
									}
								default:
									{
										Console.WriteLine("please choose your option carefully");
										break;
									}


							}
							break;
						}
					case 2:
						{
							Console.WriteLine("Enter Your Id to check your Balance");
							id = Convert.ToInt32(Console.ReadLine());
							Account ac = accounts.Find(x => x.Id == id);

							Console.WriteLine($"Hey ,{ac.Name} your account balance is: {ac.Balance}");

							break;
						}
					case 3:
						{
							Console.WriteLine("Enter your Id, to withdraw money from your account");
							id = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("Enter the ammount you want to Withdraw");
							Account ac = accounts.Find(x => x.Id == id);
							ac.Widthdraw(Convert.ToDouble(Console.ReadLine()));
							break;
						}
					case 4:
						{
							Console.WriteLine("Enter the ID and Ammount to  Deposit in your Account:");
							accounts.Find(x => x.Id == Convert.ToInt32(Console.ReadLine())).Deposite(Convert.ToDouble(Console.ReadLine()));
							break;
						}
					case 5:
						{
							Console.WriteLine("YOU CHOOSE TO EXIT FROM THE ACCOUNT APPICATION");
							Environment.Exit(0);
							break;
						}
				}

			}


			Console.ReadLine();
		}
		
	}
}
