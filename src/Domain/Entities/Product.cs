using CleanArchitectureBDD.Domain.Common;

namespace CleanArchitectureBDD.Domain.Entities;
public class Product : BaseAuditableEntity
{
    public Product(Guid id, string name, decimal? price)
        : base(id)
    {
        Name = name;
        Price = price;
    }

    public decimal? Price { get; }

    public string Name { get; }
}