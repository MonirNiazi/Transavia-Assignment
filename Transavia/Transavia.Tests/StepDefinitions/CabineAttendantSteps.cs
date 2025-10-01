using OpenQA.Selenium;
using Reqnroll;
using Transavia.Tests.PageObjects;

namespace Transavia.Tests.StepDefinitions
{
    [Binding]
    public class CabineAttendantSteps
    {
        private readonly CabineAttendantPO cabineAttendantPO;
        
        public CabineAttendantSteps()
        {
            var driver = (IWebDriver)ScenarioContext.Current["WebDriver"];
            cabineAttendantPO = new CabineAttendantPO(driver);
        }
        
        [Then(@"I should see the url (.*)")]
        public void IShouldSeeTheUrl(string expectedUrl)
        {
            cabineAttendantPO.VerifyPageUrl(expectedUrl);
        }
        
        [When(@"I click on the aanmelden jobalert button")]
        public void IClickOnTheAanmeldenJobalertButton()
        {
            cabineAttendantPO.ClickOnAanmeldenJobAlertButton();
        }
    }
}