namespace Behavioral_Visitor
{
	public class RestaurantClass : Client
	{
		public RestaurantClass(string name, string email) : base(name, email)
		{
		}

		public override void Accept(IVisitor visitor)
		{
			visitor.VisitRestaurant(this);
		}
	}
}