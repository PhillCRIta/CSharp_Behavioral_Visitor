using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Visitor
{
	internal abstract class ClientBAD
	{
		//the client class contain both method and data of the client,
		//this class violate the single responsability principle
		protected string _name;
		protected string _email;
		protected ClientBAD(string name, string email)
		{
			_name = name;
			_email = email;
		}
		public abstract void SendEmail();
	}
}
