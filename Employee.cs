using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Employee
	{	

		public int Id { get; set; }
		public string Name { get; set; }	
		public Account AccountType {  get; set; }
		public double InterestRate { get; set; }
		public double Balance {  get; set; }

	}
}
