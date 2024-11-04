using TDDSI.RESTAURANT.BACKEND.Application.Messaging;
using TDDSI.RESTAURANT.BACKEND.Domain.Abstractions;
using TDDSI.RESTAURANT.BACKEND.Domain.WeatherForecasts;
using TDDSI.RESTAURANT.BACKEND.Domain.WeatherForecasts.Dtos;

namespace TDDSI.RESTAURANT.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
internal sealed class WeatherForecastQueryHandler(
        WeatherForecastService forecastService
    ) : IQueryHandler<WeatherForecastQuery, WeatherForecastResponse> {

    public async Task<Result<WeatherForecastResponse>> Handle( WeatherForecastQuery request
        , CancellationToken cancellationToken
    ) {

        IEnumerable<WeatherForecastDto> weatherForecasts = await forecastService.WeatherForecastsAsync();
        return new WeatherForecastResponse( weatherForecasts );
    }
}
