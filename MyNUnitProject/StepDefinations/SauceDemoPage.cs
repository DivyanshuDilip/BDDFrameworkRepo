using MyNUnitProject.Driver;
using MyNUnitProject.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MyNUnitProject.StepDefinitions
{
    [Binding]
    class SauceDemoPage
    {
        private IWebDriver driver;
        private SauceDemoLoginPage login;
        private SauceDemoProductPage product;

        // Hook for driver setup before each scenario
        [BeforeScenario]
        public void Setup()
        {
            WebdriverSetup setup = new WebdriverSetup();
            driver = setup.InitializeDriver();
        }

        // Hook for driver cleanup after each scenario
        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }

        [Given(@"the user is on login page")]
        public void LoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"the user enters the correct credentials")]
        public void LoginCredentialPage()
        {
            login = new SauceDemoLoginPage(driver);
            login.LoginFunctionality(driver, "standard_user", "secret_sauce");
        }

        [Then(@"the user enters into product dashboard")]
        [Given(@"the user enters into product dashboard")]
        public void ProductPage()
        {
            product = new SauceDemoProductPage(driver);
            string titleName = driver.FindElement(product.TitleName).Text;
            Assert.That(titleName, Is.EqualTo("Products"));
        }

        [When(@"the user should select required product")]
        public void SelectProduct()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IList<IWebElement> products = driver.FindElements(product.TypeofProducts);

            foreach (var option in products)
            {
                if (option.Text == "Sauce Labs Bolt T-Shirt")
                {
                    option.Click();
                    break;
                }
            }
        }

        [Then(@"the user be on the specific product page")]
        public void ProductToCheckout()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(product.AddToCartButton).Click();
            driver.FindElement(product.ShoppingCartLink).Click();
            driver.FindElement(product.CheckoutButton).Click();
        }
    }
}
