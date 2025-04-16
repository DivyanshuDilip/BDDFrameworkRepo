using OpenQA.Selenium;

namespace MyNUnitProject.Pages
{
    class SauceDemoLoginPage
    {
        private IWebDriver driver;

        public SauceDemoLoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By Username = By.Id("user-name");
        public By Password = By.Id("password");

        public By LoginButton = By.Id("login-button");

        public void LoginFunctionality(IWebDriver driver, string username, string password)
        {
            driver.FindElement(Username).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);
            driver.FindElement(LoginButton).Click();
        }
    }
}