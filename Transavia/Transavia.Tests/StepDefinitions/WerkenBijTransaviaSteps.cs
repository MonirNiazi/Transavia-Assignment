using OpenQA.Selenium;
using Reqnroll;
using Transavia.Tests.PageObjects;

namespace Transavia.Tests.StepDefinitions
{
    [Binding]
    public class WerkenBijTransaviaSteps
    {
        private readonly WerkenBijTransaviaPO werkenBijTransaviaPO;
        
        public WerkenBijTransaviaSteps()
        {
            var driver = (IWebDriver)ScenarioContext.Current["WebDriver"];
            werkenBijTransaviaPO = new WerkenBijTransaviaPO(driver);
        }
        
        [Given(@"I am on (.*)")]
        public void IAmOnUrl(string url)
        {
            werkenBijTransaviaPO.GoToUrl(url);
            werkenBijTransaviaPO.AcceptCookies();
        }

        [When(@"I click on vakgebied (.*)")]
        public void IClickOnVakgebied(string vakgebied)
        {
            werkenBijTransaviaPO.ClickOnVakgebiedButton(vakgebied);
        }
    }
}