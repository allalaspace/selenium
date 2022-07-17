using Lc.Selenium.Specs.Drivers.Browser.Abstraction;

namespace Lc.Selenium.Specs.Drivers.Browser
{
    public interface IBrowser
    {
        /// <summary>
        ///     Returns the type of the browser
        /// </summary>
        public BrowserType BrowserType { get; }

        /// <summary>
        ///     Performs any one-time initialisation required for the browser implementation
        /// </summary>
        dynamic Initialise(string platform);
    }
}