namespace CleanArchitectureBDD.WebUI.AcceptanceTests.Drivers
{
    public interface IShoppingBasketDriver
    {
        void Place(Guid id);
        void Delete(Guid id);
        void SetQuantity(Guid id, int quantity);
        void ContainsTypesOfItems(int expectedAmount);
        void ContainsTotalItems(int expectedQuantity);
        void ShowsTotalPriceOf(decimal expectedTotalPrice);
        void ContainsCopiesOf(Guid id, int expectedQuantity);
    }
}
