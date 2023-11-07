using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. public void Deposit(double amt) { }
//This method will increase amount in balance.
//In CurrentAccount user can have negative balance.
//When use withdraw money they should get SMS and EMAIL about new balance and amount withdrawn.
namespace ConsoleApp3
{
	 class CurrentAccount : Account
	{
		public static double bal;
		const string acType = "CURRENT";
		public CurrentAccount(int id, string name, double balance):
			base(acType, id, name, balance)
		{
			bal = Balance;
		}
		public override  void Widthdraw(double amt)  
		{
			Balance = Balance - amt;
			string str = string.Format($"{amt} is deducted from your Saving Account");
			Message message = new Message(str);
		}
		public static double Payinterest(Employee e)
		{


			if (e == null)
			{
				throw new Exception("Employee is not registered in the Database");
			}
			if (e.Balance < bal && e.Balance > bal)
			{
				throw new Exception("Employees Balance Doesn't match");
			}
			if (e.InterestRate <= 0)
			{
				throw new Exception("Bank is not providing him any Intrest ");
			}

			double interest = e.Balance * e.InterestRate;

			e.Balance += interest;

			return interest;
		}
	}
}
