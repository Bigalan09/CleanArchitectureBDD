using CleanArchitectureBDD.Domain.Entities;
using CleanArchitectureBDD.Domain.Exceptions;
using FluentValidation;
using MediatR;
using System.Text;

namespace CleanArchitectureBDD.Application.Basket.AddToBasket
{
    internal class AddToBasketCommandHandler : IRequestHandler<AddToBasketCommand, Unit>
    {
        private readonly IApplicationContext _context;
        private readonly IValidator<AddToBasketCommand> _addToBasketCommandValidator;

        public AddToBasketCommandHandler(
            IApplicationContext context,
            IValidator<AddToBasketCommand> addToBasketCommandValidator)
        {
            _context = context;
            _addToBasketCommandValidator = addToBasketCommandValidator;
        }

        public async Task<Unit> Handle(AddToBasketCommand request, CancellationToken cancellationToken)
        {
            var validationResults = await _addToBasketCommandValidator.ValidateAsync(request);
            if (!validationResults.IsValid)
            {
                var failures = validationResults.Errors.ToList();
                var message = new StringBuilder();
                failures.ForEach(f => message.AppendLine(f.ErrorMessage));
                throw new ValidationException(message.ToString());
            }

            Product? product = _context.Products.Where(p => p.Id == request.Id).SingleOrDefault();
            if (product == null)
                throw new NotFoundException(nameof(Product), request.Id);

            _context.ShoppingBasket.Items.Add(product, request.Quantity);

            return Unit.Value;
        }
    }
}
