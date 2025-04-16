using OpenQA.Selenium;

namespace MyNUnitProject.Pages
{
    class SauceDemoCustomerDetailPage
    {
        private IWebDriver driver;

        public SauceDemoCustomerDetailPage(IWebDriver driver)
        {
            this.driver=driver;
        }

        public By CustomerNameInput= By.Id("first-name");
        public By LastnameInput= By.Id("last-name");

        public By ZipcodeInput= By.Id("postal-code");
        public By ContinueButton= By.Id("continue");
    }
}