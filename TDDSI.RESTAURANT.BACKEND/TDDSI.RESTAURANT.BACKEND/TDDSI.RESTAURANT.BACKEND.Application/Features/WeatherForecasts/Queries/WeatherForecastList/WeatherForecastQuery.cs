using TDDSI.RESTAURANT.BACKEND.Application.Messaging;

namespace TDDSI.RESTAURANT.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
public record WeatherForecastQuery(
) : IQuery<WeatherForecastResponse>;
