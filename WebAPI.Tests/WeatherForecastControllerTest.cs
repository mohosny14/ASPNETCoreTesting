using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers;

namespace WebAPI.Tests
{
    public class WeatherForecastControllerTest
    {
        private WeatherForecastController _weatherForecastController;
        public WeatherForecastControllerTest()
        {
            _weatherForecastController = new();
        }
        [Fact]
        public void Get_WhenCalled_RetuenOkResult()
        {
            // 1- (Arrange) => prepare everything for test , creating the objects and setting them up as necessary.

            // Done in this case

            // 2- (Act) => this where the method we are testing is executed.
            var okResult = _weatherForecastController.Get();

            // 3- (Assert) => final part which we compare whate we expect to happen with the actual result of the test method execution.
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnFiveItemsResult()
        {
            // Act
            var okResult = _weatherForecastController.Get().Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<WeatherForecast[]>(okResult.Value);
            Assert.Equal(5, items.Length);
        }
    }
}