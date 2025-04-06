
using Mediator.Class;
using Mediator.Implementation;
using Mediator.Interface;

// Mediator Pattern:
// A behavioral design pattern that defines an object (the mediator) that centralizes
// communication between objects, preventing direct interaction between them.
// It promotes loose coupling by ensuring that objects only interact through the mediator,
// which handles the communication and coordination between them.


IChatRoomMediator chatRoom = new ChatRoom();

var user1 = new User("John", chatRoom);
var user2 = new User("Mahdi", chatRoom);

user1.SendMessage("Hello friends!");
user2.SendMessage("Hello John how are you?");