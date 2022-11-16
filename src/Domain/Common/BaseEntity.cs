namespace CleanArchitectureBDD.Domain.Common;

public abstract class BaseEntity
{
    public BaseEntity(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}
