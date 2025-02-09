using Microsoft.AspNetCore.Mvc.Testing;
using StockManager.API;

namespace StockManager.IntegrationTests;

public class WeatherForecastTests(WebApplicationFactory<Program> webApplicationFactory)
    : IClassFixture<WebApplicationFactory<Program>>
{
    [Fact]
    public async Task GetRequestReturnsOk()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync("/weatherforecast");
        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    }
}