using OpenQA.Selenium;

namespace Lc.Selenium.Specs.Drivers.Browser.Abstraction
{
    public interface ISeleniumTestDriver
    {
        IWebDriver Init(string browserName, string platform);

        void Cleanup();
    }
}