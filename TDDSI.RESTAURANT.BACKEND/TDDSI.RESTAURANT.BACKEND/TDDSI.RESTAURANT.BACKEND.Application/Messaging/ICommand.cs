using MediatR;
using TDDSI.RESTAURANT.BACKEND.Domain.Abstractions;

namespace TDDSI.RESTAURANT.BACKEND.Application.Messaging;
public interface ICommand : IRequest<Result>, IBaseCommand {

}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand {

}