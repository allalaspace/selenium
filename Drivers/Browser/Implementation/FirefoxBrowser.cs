using Lc.Selenium.Specs.Drivers.Browser.Abstraction;
using OpenQA.Selenium.Firefox;

namespace Lc.Selenium.Specs.Drivers.Browser.Implementation
{
    public class FirefoxBrowser : BrowserBase
    {
        public override BrowserType BrowserType => BrowserType.Firefox;

        protected override dynamic InitiliseInternal(string platform)
        {
            return new FirefoxOptions
            {
                PlatformName = platform
            };
        }
    }
}