using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Transavia.Tests.PageObjects
{
    public class WerkenBijTransaviaPO
    {
        private IWebElement acceptCookiesButton => driver.FindElement(By.XPath("//button[contains(., 'Alles accepteren')]"));
        
        private string genericVakgebiedenButtons =
            "//div[contains(., '{0}')]/following-sibling::div//a[contains(normalize-space(.), 'Lees meer')][1]";
        
        private readonly IWebDriver driver;
        public WerkenBijTransaviaPO(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOnVakgebiedButton(string vakgebied)
        {
            //The XPath will be created by replacing the 'placeholder' with the string input
            //This makes this method re-useable for other vakgebieden as well
            string vakgebiedXpath = string.Format(genericVakgebiedenButtons, vakgebied);
            driver.FindElement(By.XPath(vakgebiedXpath)).Click();
        }
        
        public void AcceptCookies()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement acceptButton = wait.Until(ExpectedConditions.ElementToBeClickable(acceptCookiesButton));
                acceptButton.Click();
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Cookies accept button was not found or not clickable within timeout.");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Cookies accept button not found.");
            }
        }
    }
}
