### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Visitor pattern
 This patter separate algorithms or behaviors from the objects on wich they operate. \
 You need to extract the algorithms or behaviors in another class.

In our example I use a polimorphism to send email, but if I would add more and more method to a base class, i need to reopen every child class. This violate OPEN_CLOSE principle because I need to reopen all class and violate SINGLE-RESPONSABILITY because each class nedd to implement different method to realize multiple responsability.