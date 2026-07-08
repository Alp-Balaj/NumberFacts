using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace NumberFacts.Tests;

public class SwaggerUiTests
{
    private static WebApplicationFactory<Program> CreateFactory() =>
        new WebApplicationFactory<Program>().WithWebHostBuilder(builder =>
            builder.UseEnvironment("Development"));

    [Fact]
    public async Task Swagger_InDevelopment_ReturnsOk()
    {
        using var factory = CreateFactory();
        using var client = factory.CreateClient();

        var response = await client.GetAsync("/swagger");

        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task Swagger_InDevelopment_ReferencesOpenApiDocument()
    {
        using var factory = CreateFactory();
        using var client = factory.CreateClient();

        var html = await client.GetStringAsync("/swagger");

        Assert.Contains("/openapi/v1.json", html);
    }

    [Fact]
    public async Task OpenApiDocument_ListsNumberFactsAndWeatherForecastOperations()
    {
        using var factory = CreateFactory();
        using var client = factory.CreateClient();

        var document = await client.GetStringAsync("/openapi/v1.json");

        Assert.Contains("/numberfacts/{n}", document);
        Assert.Contains("/weatherforecast", document);
    }
}
