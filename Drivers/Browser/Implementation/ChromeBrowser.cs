using Lc.Selenium.Specs.Drivers.Browser.Abstraction;
using OpenQA.Selenium.Chrome;

namespace Lc.Selenium.Specs.Drivers.Browser.Implementation
{
    public class ChromeBrowser : BrowserBase
    {
        public override BrowserType BrowserType => BrowserType.Chrome;

        protected override dynamic InitiliseInternal(string platform)
        {
            return new ChromeOptions
            {
                PlatformName = platform
            };
        }
    }
}