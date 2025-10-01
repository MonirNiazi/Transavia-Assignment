using OpenQA.Selenium;
using Reqnroll;
using Transavia.Tests.PageObjects;

namespace Transavia.Tests.StepDefinitions
{
    [Binding]
    public class JobAlertsSteps
    {
        private readonly JobAlertsPO jobAlertsPO;
        
        public JobAlertsSteps()
        {
            var driver = (IWebDriver)ScenarioContext.Current["WebDriver"];
            jobAlertsPO = new JobAlertsPO(driver);
        }
        
        [Then(@"I should see the Aanmelden Jobalerts page")]
        public void IShouldSeeTheAanmeldenJobAlertsPage()
        {
            jobAlertsPO.VerifyAanmeldenJobAlertsModalIsShown();
        }

        [When(@"I fill in my email address with (.*)")]
        public void IFillInMyEmailAddressWith(string email)
        {
            jobAlertsPO.FillInEmail(email);
        }

        [When(@"I set my Voorkeursafdeling to IT")]
        public void ISetVoorkeursafdelingToIT()
        {
            jobAlertsPO.SelectVoorkeursAfdelingToIT();
        }

        [When(@"I set my Voorkeurstaal to English")]
        public void ISetMyVoorkeurstaalToEnglish()
        {
            jobAlertsPO.SetLanguageToEnglish();
        }

        [When(@"I set Hoe vaak wil je vacaturemeldingen ontvangen to wekelijks")]
        public void ISetHoeVaakWilJeVacaturemeldingenToWekelijks()
        {
            jobAlertsPO.SetFrequencyToWekelijks();
        }

        [When(@"I check the box Ik ga akkoord emails van Transavia te ontvangen")]
        public void ICheckTheAgreementCheckbox()
        {
            jobAlertsPO.CheckAgreementCheckbox();
        }

        [Then(@"I should see the button Aanmelden")]
        public void IShouldSeeTheButtonAanmelden()
        {
            jobAlertsPO.VerifyAanmeldenButtonisShown();
        }
    }
}