using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Visitor
{
	internal class PdfGEneratorVisitor(string pathToSave) : IVisitor
	{
		public void VisitLaw(LawClient lawClient)
		{
			Console.WriteLine("Export to pdf law client, save to: " + pathToSave);
		}

		public void VisitRestaurant(RestaurantClass restaurantClass)
		{
			Console.WriteLine("Export to pdf restaurant class, save to: " + pathToSave);
		}

		public void VisitRetail(RetailClient retailClient)
		{
			Console.WriteLine("Export to pdf retail class, save to: " + pathToSave);
		}
	}
}
