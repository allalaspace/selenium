using System;

namespace Lc.Selenium.Specs.Drivers.Browser.Abstraction
{
    public abstract class BrowserBase : IBrowser
    {
        public abstract BrowserType BrowserType { get; }

        public dynamic Initialise(string platform)
        {
            try
            {
                return InitiliseInternal(platform);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected abstract dynamic InitiliseInternal(string platform);
    }
}