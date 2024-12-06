using ApplicationTest.Fixture;
using EaApplicationTest.Pages;
using Framework.Config;
using Framework.Driver;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationTest;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services
            .AddSingleton(ConfigReader.ReadConfig())
            .AddScoped<IPlaywrightDriver, PlaywrightDriver>()
            .AddScoped<IPlaywrightDriverInitializer, PlaywrightDriverInitializer>()
            .AddScoped<IProductPage, ProductPage>()
            .AddScoped<IProductListPage, ProductListPage>()
            .AddScoped<ITestFixtureBase, TestFixtureBase>();
    }
}