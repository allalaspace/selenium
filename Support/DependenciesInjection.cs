using Lc.Selenium.Specs.Drivers;
using Lc.Selenium.Specs.Drivers.Browser;
using Lc.Selenium.Specs.Drivers.Browser.Abstraction;
using Lc.Selenium.Specs.Drivers.Browser.Implementation;
using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;

namespace Lc.Selenium.Specs.Support
{
    public static class DependenciesInjection
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<IBrowserFactory, BrowserFactory>();
            services.AddScoped<ISeleniumTestDriver, SeleniumTestDriver>();
            services.AddTransient<IBrowser, ChromeBrowser>();
            services.AddTransient<IBrowser, FirefoxBrowser>();
            services.AddTransient<IBrowser, MicrosoftEdgeBrowser>();
            return services;
        }
    }
}