using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyNUnitProject.Driver
{
    class WebdriverSetup
    {
        public IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}