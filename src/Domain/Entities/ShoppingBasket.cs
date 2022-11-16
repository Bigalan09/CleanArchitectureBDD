using CleanArchitectureBDD.Domain.Common;

namespace CleanArchitectureBDD.Domain.Entities;

public class ShoppingBasket : BaseAuditableEntity
{
    public ShoppingBasket(Guid id)
        : base(id)
    {
        Items = new Dictionary<Product, int>();
    }

    public IDictionary<Product, int> Items { get; }
}
