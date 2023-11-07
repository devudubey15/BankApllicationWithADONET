using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
	internal class BankOfBaroda
	{ 
		static BankOfBaroda()
		{
			Console.WriteLine("Bank Of Baroda");
		}

		static void Main(string[] args)
		{
			List<Account> accounts = new List<Account>();
			accounts.Add(new SavingAccount(89, "hfuyf", 800000));
			accounts.Add(new CurrentAccount(91, "fhhjkk", 800000));
			foreach (var l in accounts)
					Console.WriteLine(l);

			Console.ReadLine();
		}
		public void Transaction()
		{

		}
	}
}
