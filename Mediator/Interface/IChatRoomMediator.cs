using Mediator.Class;

namespace Mediator.Interface;

public interface IChatRoomMediator
{
    void ShowMessage(User user, string message);
}