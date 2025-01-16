using Mediator;

ChatRoom chatRoom = new();

RegularUser lupita = new("Lupita");
RegularUser bob = new("Bob");
AdminUser charlie = new("Charlie");

chatRoom.AddUser(lupita);
chatRoom.AddUser(bob);
chatRoom.AddUser(charlie);

charlie.Send("Welcome everybody!");

lupita.Send("Hello everyone");
bob.Send("Hi lupita how are you?");
lupita.Send("Good Thanks!");

charlie.BroadcastAlert("Keep it friendly");
