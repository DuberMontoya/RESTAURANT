using TDDSI.RESTAURANT.BACKEND.Domain.WeatherForecasts;

namespace TDDSI.RESTAURANT.BACKEND.Domain.Tests;
[TestClass]
public class WeatherForecastServiceTests {

    [TestMethod]
    public void WeatherForecastList_Success() {
        //Arrange

        //Act
        var result = WeatherForecastService.WeatherForecastList();

        //Assert
        Assert.IsNotNull( result );
    }
}
