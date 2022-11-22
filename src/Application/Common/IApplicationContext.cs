using CleanArchitectureBDD.Domain.Entities;

namespace CleanArchitectureBDD.Application.Common;

public interface IApplicationContext
{
    public IList<Product> Products { get; }
    public ShoppingBasket ShoppingBasket { get; }
}
