using MediatR;
using TDDSI.RESTAURANT.BACKEND.Domain.Abstractions;

namespace TDDSI.RESTAURANT.BACKEND.Application.Messaging;
public interface IQueryHandler<TQuery, TResponse>
: IRequestHandler<TQuery, Result<TResponse>>
where TQuery : IQuery<TResponse> {

}
