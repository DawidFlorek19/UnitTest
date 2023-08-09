using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using WeatherForecast.Controllers;
using Xunit;

namespace WeatherForecast.Tests
{
    public class WeatherForecastControllerTests
    {
        private readonly WeatherForecastController _controller;

        public WeatherForecastControllerTests()
        {
            var logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger<WeatherForecastController>();
            _controller = new WeatherForecastController(logger);
        }

        [Fact]
        public void TestGetWeatherForecast()
        {
            // Act
            var result = _controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(5, result.Count());
        }
    }
}
