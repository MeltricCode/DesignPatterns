using Mediator.Interface;

namespace Mediator.Class;

public class User
{
    public string Name { get; set; }
    private IChatRoomMediator _chatRoom;

    public User(string name, IChatRoomMediator chatRoom)
    {
        Name = name;
        _chatRoom = chatRoom;
    }
    public void SendMessage(string message)
    {
        _chatRoom.ShowMessage(this, message);
    }
}