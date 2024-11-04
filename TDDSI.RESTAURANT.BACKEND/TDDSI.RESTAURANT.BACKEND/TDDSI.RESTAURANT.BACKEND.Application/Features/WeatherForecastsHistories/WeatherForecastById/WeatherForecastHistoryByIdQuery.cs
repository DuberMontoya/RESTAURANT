using TDDSI.RESTAURANT.BACKEND.Application.Messaging;

namespace TDDSI.RESTAURANT.BACKEND.Application.Features.WeatherForecastsHistories.WeatherForecastById;
public record WeatherForecastHistoryByIdQuery(
    Guid Id
) : IQuery<WeatherForecastHistoryByIdQueryResponse>;