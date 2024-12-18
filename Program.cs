/*
 Separate algorithms or behaviors from the objects on wich they operate
 You need to extract the algorithms or behaviors in another class
 */


using Behavioral_Visitor;

List<ClientBAD> clients  = new List<ClientBAD> { 
new RestaurantClassBAD("Restaurant client one", "rest@rest.rest"),
new LawClientBAD("Law client one", "client@client.client"),
};

//in this solution use a polimorphism to send email
//but if I would add more and more method to a base class, i need to reopen every child class
//this violate OPEN_CLOSE principle because I need to reopen all class
//and violate SINGLE-RESPONSABILITY because each class nedd to implement different method to realize multiple responsability
foreach (ClientBAD client in clients)
{
	client.SendEmail();
}

Console.WriteLine("*********");
Console.WriteLine("*********");

List<Client> clientsOK = new List<Client> {
new RestaurantClass("Restaurant client one", "rest@rest.rest"),
new LawClient("Law client one", "client@client.client"),
new RetailClient("Retail client one", "retail@retail.client"),
};
foreach (Client client in clientsOK)
{
	//inseide accept method you must pass a concrete visitor, to realize a function, like as sending emails.
	client.Accept(new EmailVisitor());
}
//the IVisitor is open to extend other functionality, like pdf generator
foreach (Client client in clientsOK)
{
	//inseide accept method you must pass a concrete visitor, to realize a function, like as sending emails.
	client.Accept(new PdfGEneratorVisitor("C:\\"));
}