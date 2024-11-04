using MediatR;

namespace TDDSI.RESTAURANT.BACKEND.Application.Messaging;
public interface INotifyHandler<TCommand> : INotificationHandler<TCommand>
where TCommand : INotify {

}
