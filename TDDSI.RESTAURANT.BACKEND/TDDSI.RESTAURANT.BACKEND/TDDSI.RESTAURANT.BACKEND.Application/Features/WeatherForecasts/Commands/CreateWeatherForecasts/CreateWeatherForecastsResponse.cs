namespace TDDSI.RESTAURANT.BACKEND.Application.Features.WeatherForecasts.Commands.CreateWeatherForecasts;
public record CreateWeatherForecastsResponse(
    IEnumerable<Guid> Ids
);
