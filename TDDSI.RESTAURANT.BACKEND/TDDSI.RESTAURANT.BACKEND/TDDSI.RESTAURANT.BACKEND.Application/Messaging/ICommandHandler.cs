using MediatR;
using TDDSI.RESTAURANT.BACKEND.Domain.Abstractions;

namespace TDDSI.RESTAURANT.BACKEND.Application.Messaging;
public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
where TCommand : ICommand {

}

public interface ICommandHandler<TCommand, TResponse>
: IRequestHandler<TCommand, Result<TResponse>>
where TCommand : ICommand<TResponse> {

}