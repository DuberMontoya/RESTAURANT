using TDDSI.RESTAURANT.BACKEND.Application.Messaging;

namespace TDDSI.RESTAURANT.BACKEND.Application.Features.WeatherForecasts.Events.NotifyWeatherForecastCreated;
public record NotifyWeatherForecastCreatedCommand(
    string Proccess
) : INotify;
