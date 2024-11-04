using TDDSI.RESTAURANT.BACKEND.Domain.WeatherForecasts.Dtos;

namespace TDDSI.RESTAURANT.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
public record WeatherForecastResponse(
    IEnumerable<WeatherForecastDto> WeatherForecasts
);
