using OpenQA.Selenium;

namespace Transavia.Tests.PageObjects
{
    public class JobAlertsPO
    {
        private readonly IWebDriver driver;
        
        private IWebElement aanmeldenJobAlertText => driver.FindElement(By.XPath("//div[contains(@role, 'dialog')]//h3[contains(., 'Aanmelden Jobalerts')]"));
        private IWebElement emailField => driver.FindElement(By.XPath("//input[@name='email']"));
        private IWebElement voorkeursAfdelingDropDown => driver.FindElement(By.XPath("//button[@aria-label='Voorkeursafdeling']"));
        private IWebElement dropdownOptionIT => driver.FindElement(By.XPath("//li[@data-testid='public-option'][contains(., 'IT')]"));
        private IWebElement radioButtonEnglish => driver.FindElement(By.XPath("//input[@value='en']/following-sibling::label[span[contains(., 'English')]]"));
        private IWebElement radioButtonWekelijks =>
            driver.FindElement(
                By.XPath("//input[@value='weekly']/following-sibling::label[span[contains(., 'Wekelijks')]]"));
        private IWebElement checkboxAgreement => driver.FindElement(By.XPath("//form[@id='job-alert-subscription-form']//input[@name='legalAgreement']/following-sibling::div"));
        private IWebElement aanmeldenButton => driver.FindElement(By.XPath("//form[@id='job-alert-subscription-form']//button[contains(., 'Aanmelden')]"));


        public JobAlertsPO(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public void VerifyAanmeldenJobAlertsModalIsShown()
        {
            Assert.True(
                aanmeldenJobAlertText.Displayed,
                "The 'Aanmelden Jobalerts' modal is not shown."
            );
        }

        public void FillInEmail(string email)
        {
            emailField.SendKeys(email);
        }

        public void SelectVoorkeursAfdelingToIT()
        {
            voorkeursAfdelingDropDown.Click(); //To open the dropdown
            dropdownOptionIT.Click();        
            voorkeursAfdelingDropDown.Click(); //To close the dropdown
        }
        
        public void SetLanguageToEnglish()
        {
            radioButtonEnglish.Click();
        }

        public void SetFrequencyToWekelijks()
        {
            radioButtonWekelijks.Click();
        }

        public void CheckAgreementCheckbox()
        {
            checkboxAgreement.Click();
        }

        public void VerifyAanmeldenButtonisShown()
        {
            Assert.True(
                aanmeldenButton.Displayed,
                "The 'Aanmelden' button is not shown."
            );
        }
    }
}
