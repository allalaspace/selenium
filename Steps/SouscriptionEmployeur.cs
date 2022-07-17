using Lc.Selenium.Specs.Drivers.Browser.Abstraction;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace Lc.Selenium.Specs.Steps
{
    [Binding]
    public class SouscriptionEmployeur
    {
        private IWebDriver _driver;
        private readonly ISeleniumTestDriver _sTDriver;

        private const string test_url = "https://front-souscription.dev.projetlucie.com/";

        public SouscriptionEmployeur(ISeleniumTestDriver sTDriver)
        {
            _sTDriver = sTDriver;
        }

        [Given(@"Je Suis connecté à l'espace employeur (.*) and (.*)")]
        public void GivenJeSuisConnecteALEspaceSouscriptionAnd(string browser, string platform)
        {
            _driver = _sTDriver.Init(browser, platform);
            _driver.Url = test_url;
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Then(@"Je découvre les offres je sélectionne le boutton découvrir")]
        public void ThenJeDecouvreLesOffresJeSelectionneLeBouttonDecouvrir()
        {
            _driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        [Then(@"Je dispose la session")]
        public void ThenJeDisposeLaSession()
        {
            _driver.Quit();
        }
    }
}