using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Create a  abstract class Account having member
//a. Id [Let your application generate id, it is readonly]
//b.Name[write getter, setter Method Give Validation Length of  name can not be less then 2 and greater then 15]
//c.Balance[write getter, setter, you can not set value  outside class other than child class]
//It has two methods
//1. public abstract withdraw(double amt);
//2. public void Deposit(double amt) { }
//This method will increase amount in balance.

namespace ConsoleApp3
{
	public abstract class Account
	{
		string str;
		public Account(string acType, int id, string name,double balance) { 
			AccountType = acType;
			Id = id;
			Name = name;
			Balance = balance;
		}

		public string AccountType { get; set; }
		public int Id { get; set; }
		public string Name {
			set
			{
				if (value.Length<2 || value.Length > 15)
				{
					throw new Exception("Name should be of greter than 2 letter and lesser than 15 letters");
				}
				else
				{
					
					str = value;
				}	
				
			}
			get
			{
				return str;
			}
		}
		public double Balance { get; set; }

		public abstract void Widthdraw(double amt);

		public void Deposite(double amt)
		{
			Balance += amt;
		}
	}
}
