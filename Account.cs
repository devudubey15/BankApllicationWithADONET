﻿using System;
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
		public int Id { get; set; }
		public string Name { get; set; }
		protected double Balance { get; set; }

		public abstract void Widthdraw(double amt);
		public abstract void Deposite(double amt);
	}
}
