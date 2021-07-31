using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        // Arrange
        WeatherForecastController oWFC = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            // Act
            var oResult = oWFC.GetOwnerName(1);

            // Assert
            Assert.Equal("Vandana Sharma2", oResult);
        }
    }
}
