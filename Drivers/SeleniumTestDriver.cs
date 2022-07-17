using Lc.Selenium.Specs.Drivers.Browser.Abstraction;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace Lc.Selenium.Specs.Drivers
{
    public class SeleniumTestDriver : ISeleniumTestDriver
    {
        private const string UriGrid = "http://localhost:4444/wd/hub/";
        private IWebDriver _driver;
        private readonly IBrowserFactory _browserFactory;

        public SeleniumTestDriver(IBrowserFactory browserFactory)
        {
            _browserFactory = browserFactory;
        }

        public IWebDriver Init(string browserName, string platform)
        {
            Enum.TryParse<BrowserType>(browserName, true, out BrowserType browserType);
            var browser = _browserFactory.GetBrowser(browserType);
            var browserInstance = browser.Initialise(platform);
            _driver = new RemoteWebDriver(new Uri(UriGrid), browserInstance);
            return _driver;
        }

        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}