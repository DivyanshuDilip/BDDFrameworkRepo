using OpenQA.Selenium;

namespace MyNUnitProject.Pages
{

    class SauceDemoProductPage
    {

        private IWebDriver driver;

        public SauceDemoProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By TypeofProducts = By.XPath("//div[@class='inventory_item_description']//a");

        public By AddToCartButton = By.XPath("//button[text()='Add to cart']");

        public By ShoppingCartLink = By.XPath("//div[@id='shopping_cart_container']/a");

        public By RemoveButton = By.Id("remove-sauce-labs-bolt-t-shirt");

        public By TitleName= By.XPath("//span[@class='title']");
    }
}