using Lc.Selenium.Specs.Drivers.Browser.Abstraction;
using OpenQA.Selenium.Edge;

namespace Lc.Selenium.Specs.Drivers.Browser.Implementation
{
    public class MicrosoftEdgeBrowser : BrowserBase
    {
        public override BrowserType BrowserType => BrowserType.MicrosoftEdge;

        protected override dynamic InitiliseInternal(string platform)
        {
            return new EdgeOptions
            {
                PlatformName = platform
            };
        }
    }
}