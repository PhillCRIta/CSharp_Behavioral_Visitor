namespace Behavioral_Visitor
{
	public interface IVisitor
	{
		void VisitRetail(RetailClient retailClient);
		void VisitLaw(LawClient lawClient);
		void VisitRestaurant(RestaurantClass restaurantClass);
	}
}