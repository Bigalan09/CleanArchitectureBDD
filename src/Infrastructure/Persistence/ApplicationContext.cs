using CleanArchitectureBDD.Application.Interfaces;
using CleanArchitectureBDD.Domain.Entities;

namespace CleanArchitectureBDD.Infrastructure.Persistence
{
    internal class ApplicationContext : IApplicationContext
    {
        private List<Product> _products;
        private ShoppingBasket _shoppingBasket;

        public ApplicationContext()
        {
            _products = new List<Product>();
            _shoppingBasket = new ShoppingBasket(Guid.NewGuid());
        }

        public IList<Product> Products  => _products;

        public ShoppingBasket ShoppingBasket => _shoppingBasket;
    }
}
