using TDDSI.RESTAURANT.BACKEND.Application.Messaging;

namespace TDDSI.RESTAURANT.BACKEND.Application.Features.WeatherForecasts.Commands.CreateWeatherForecasts;
public record CreateWeatherForecastsCommand(
    ) : ICommand<CreateWeatherForecastsResponse>;
