using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Message obj1 = new Message();
// obj1.eventmsg(Account ac);
namespace ConsoleApp3
{
	public delegate void msg(string s);

	public class Message {
		public static  event msg eventmsg;

		public Message()
		{
			eventmsg += new msg(TextMessage); 
			eventmsg += new msg(Email);

		}
		static DateTime dateTime = DateTime.Now;
		public static void TextMessage(string s)
		{
			
			string str = string.Format($"Message: Dear user A/C X5638 debited by {} on date" +
										$" {dateTime} trf to TINKU RAJARAM CH Refno 367628226681." +
										$" If not u? call 1800111109. -BOB");
			Console.WriteLine( str );
		}
		public static void Email(string s)
		{
			string str = string.Format($"Email: Dear user A/C X5638 debited by {} on date" +
										$" {dateTime} trf to TINKU RAJARAM CH Refno 367628226681." +
										$" If not u? call 1800111109. -BOB");
		}
	}
}
