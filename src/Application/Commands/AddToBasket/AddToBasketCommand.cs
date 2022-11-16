using CleanArchitectureBDD.Application.CQRS.Interfaces;

namespace CleanArchitectureBDD.Application.Commands.AddToBasket;

internal class AddToBasketCommand : ICommand
{
    public AddToBasketCommand(
        Guid id,
        int quantity)
    {
        Id = id;
        Quantity = quantity;
    }

    public Guid Id { get; }
    public int Quantity { get; }
}
