using Lc.Selenium.Specs.Drivers.Browser.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace Lc.Selenium.Specs.Drivers.Browser
{
    public class BrowserFactory : IBrowserFactory
    {
        private readonly IList<IBrowser> _browsers;

        public BrowserFactory(IEnumerable<IBrowser> browsers)
        {
            _browsers = browsers.ToList();
        }

        public IBrowser GetBrowser(BrowserType browserType)
        {
            return _browsers.FirstOrDefault(c => c.BrowserType == browserType);
        }
    }
}