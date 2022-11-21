using CleanArchitectureBDD.Domain.Entities;

namespace CleanArchitectureBDD.Application;

public interface IApplicationContext
{
    public IList<Product> Products { get; }
    public ShoppingBasket ShoppingBasket { get; }
}
