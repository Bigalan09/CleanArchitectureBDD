using FluentValidation;

namespace CleanArchitectureBDD.Application.Basket.AddToBasket
{
    internal class AddToBasketCommandValidator : AbstractValidator<AddToBasketCommand>, IValidator<AddToBasketCommand>
    {
        public AddToBasketCommandValidator()
        {
            RuleFor(p => p.Quantity)
                .LessThanOrEqualTo(0)
                .WithMessage($"{nameof(AddToBasketCommand)}.{nameof(AddToBasketCommand.Quantity)} must be 1 or more");
        }
    }
}
