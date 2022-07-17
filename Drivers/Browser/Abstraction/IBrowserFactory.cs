namespace Lc.Selenium.Specs.Drivers.Browser.Abstraction
{
    public interface IBrowserFactory
    {
        IBrowser GetBrowser(BrowserType browserType);
    }
}