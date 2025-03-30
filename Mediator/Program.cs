
using Mediator.Class;
using Mediator.Implementation;
using Mediator.Interface;

IChatRoomMediator chatRoom = new ChatRoom();

var user1 = new User("John", chatRoom);
var user2 = new User("Mahdi", chatRoom);

user1.SendMessage("Hello friends!");
user2.SendMessage("Hello John how are you?");