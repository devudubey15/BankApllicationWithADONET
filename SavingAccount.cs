using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In SavingAccount minimum balance of 1000 need to maintain. Declare const double  minbala=1000

//When use withdraw money they should get SMS and EMAIL about new balance and amount withdrawn.
//Do transaction and ensure user can not withdraw more then the balance. Also ensure it maintain minimum
//balance of 1000 in Saving Account.

// In SavingAccount write public static double Payinterest(Employee e) this method will return interest
//amount  and increase the balance  If data is in-validation then your application should throw
//exception


namespace ConsoleApp3
{
	 class SavingAccount : Account
	{
		const double minbala = 1000;
		

		public override void Widthdraw(double amt)
		{
			if(Balance > minbala)
			{
				Balance = Balance - amt;
				string str = string.Format($"{amt} id deducted from your Saving Account");
				Message message = new Message(str);
			}
			else
			{
				throw new Exception($"you cannot withdraw further your account balance is {Balance}");
			}
		}

		

		public static double Payinterest(Employee e)
		{
			SavingAccount account = new SavingAccount();

			if (e == null) 
			{
				throw new Exception("Employee is not registered in the Database");
			}
			if(e.Balance < account.Balance && e.Balance > account.Balance)
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
