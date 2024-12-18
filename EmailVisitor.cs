using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Visitor
{
	internal class EmailVisitor : IVisitor
	{
		public void VisitLaw(LawClient lawClient)
		{
			Console.WriteLine("Sending marketing LawClient email, address: " + lawClient.GetEmail());
		}

		public void VisitRestaurant(RestaurantClass restaurantClass)
		{
			Console.WriteLine("Sending marketing RestaurantClass email, address: " + restaurantClass.GetEmail());
		}

		public void VisitRetail(RetailClient retailClient)
		{
			Console.WriteLine("Sending marketing RetailClient email, address: " + retailClient.GetEmail());
		}
	}
}
