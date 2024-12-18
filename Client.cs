using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Visitor
{
	public abstract class Client
	{
		protected string _name;
		protected string _email;

		protected Client(string name, string email)
		{
			_name = name;
			_email = email;
		}

		public string GetEmail() => _email;

		//the visitor object contain the behavior,  and will operate on specific object
		//when I call Accept method i can decide which behavior pass to it using one concrete visitor, like as EmailSendingVisitor
		public abstract void Accept(IVisitor visitor);
	}
}
