using Mediator.Class;
using Mediator.Interface;

namespace Mediator.Implementation;

public class ChatRoom : IChatRoomMediator
{
    public void ShowMessage(User user, string message)
    {
        Console.WriteLine($"{DateTime.Now.ToShortTimeString()} | {user.Name}: {message}");
    }
}