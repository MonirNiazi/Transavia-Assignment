using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;

namespace Transavia.Tests.Hooks
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            driver = new ChromeDriver(options);
            ScenarioContext.Current["WebDriver"] = driver;
        }
        
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}