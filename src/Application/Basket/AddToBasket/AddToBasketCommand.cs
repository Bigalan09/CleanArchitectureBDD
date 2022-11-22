using MediatR;

namespace CleanArchitectureBDD.Application.Basket.AddToBasket;

public record AddToBasketCommand(
    Guid Id,
    int Quantity) : IRequest;