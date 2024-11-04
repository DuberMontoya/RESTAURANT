using MediatR;
using TDDSI.RESTAURANT.BACKEND.Domain.Abstractions;

namespace TDDSI.RESTAURANT.BACKEND.Application.Messaging;
public interface IQuery<TResponse> : IRequest<Result<TResponse>> {

}