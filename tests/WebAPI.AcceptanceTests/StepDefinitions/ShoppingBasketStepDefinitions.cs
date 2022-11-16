using CleanArchitectureBDD.WebUI.AcceptanceTests.Drivers;

namespace CleanArchitectureBDD.WebUI.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class ShoppingBasketStepDefinitions
    {
        private readonly IShoppingBasketDriver _driver;

        public ShoppingBasketStepDefinitions(IShoppingBasketDriver driver)
        {
            _driver = driver;
        }

        [Then(@"my shopping basket should be empty")]
        public void ThenMyShoppingBasketShouldBeEmpty()
        {
            _driver.ContainsTypesOfItems(0);
        }
    }
}
