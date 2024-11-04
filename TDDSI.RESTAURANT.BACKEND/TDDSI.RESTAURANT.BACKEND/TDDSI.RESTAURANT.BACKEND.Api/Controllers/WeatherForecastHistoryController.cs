using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using TDDSI.RESTAURANT.BACKEND.Application.Features.WeatherForecastsHistories.WeatherForecastById;
using TDDSI.RESTAURANT.BACKEND.Application.Messaging;
using TDDSI.RESTAURANT.BACKEND.Domain.Abstractions;
using TDDSI.RESTAURANT.BACKEND.Domain.Helpers;

namespace TDDSI.RESTAURANT.BACKEND.Api.Controllers;
public class WeatherForecastHistoryController(
      ILogger<WeatherForecastHistoryController> logger
    , IDispatch dispatch
) : ControllerBase {

    [HttpGet( "weatherForecastHistoryById" )]
    public async Task<ActionResult<Result>> WeatherForecastHistoryByAsync(
          Guid Id
        , CancellationToken cancellationToken
    ) {
        logger.LogInformation(
            "En la siguiente fecha {date} a las {time}, se llamo el endpoint {endpoint} de la clase {class}",
                DateTime.Now.ZoneByIdPacificStandardTime().ToString( "dd/MM/yyyy", provider: new CultureInfo( "es-CO" ) ),
                DateTime.Now.ZoneByIdPacificStandardTime().ToString( "hh:mm tt" ),
                "WeatherForecastHistoryAsync",
                nameof( WeatherForecastHistoryController )
        );

        return await dispatch.Send(
            new WeatherForecastHistoryByIdQuery( Id )
            , cancellationToken
        );
    }
}
