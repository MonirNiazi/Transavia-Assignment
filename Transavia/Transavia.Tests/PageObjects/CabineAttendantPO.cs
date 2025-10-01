using OpenQA.Selenium;

namespace Transavia.Tests.PageObjects
{
    public class CabineAttendantPO
    {
        private readonly IWebDriver driver;
        
        private IWebElement aanmeldenJobAlertButton => driver.FindElement(By.XPath("//button[contains(text(), 'Aanmelden Jobalert')]"));

        public CabineAttendantPO(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void VerifyPageUrl(string expectedUrl)
        {
            Assert.AreEqual(expectedUrl, driver.Url);
        }
        
        public void ClickOnAanmeldenJobAlertButton()
        {
            aanmeldenJobAlertButton.Click();
        }
    }
}
