using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Visitor
{
	internal class RestaurantClassBAD:ClientBAD
	{
		private readonly string name;
		private readonly string email;

		public RestaurantClassBAD(string name, string email) : base(name, email)
		{
			this.name = name;
			this.email = email;
		}
		public override void SendEmail()
		{
			Console.WriteLine("Sending email from restaurant client to "+ email);
		}
	}
}
