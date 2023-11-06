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
		public override  void Widthdraw(double amt)
		{
			Balance = Balance - amt;
			string str = string.Format($"{amt} is deducted from your Saving Account");
			Message message = new Message(str);
		}

	}
}
