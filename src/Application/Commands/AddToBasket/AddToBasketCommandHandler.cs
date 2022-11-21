using CleanArchitectureBDD.Application.CQRS;
using CleanArchitectureBDD.Domain.Entities;
using CleanArchitectureBDD.Domain.Exceptions;
using FluentValidation;
using System.Text;

namespace CleanArchitectureBDD.Application.Commands.AddToBasket
{
    internal class AddToBasketCommandHandler : ICommandHandler<AddToBasketCommand>
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

        public async Task Handle(AddToBasketCommand command)
        {
            var validationResults = await _addToBasketCommandValidator.ValidateAsync(command);
            if (!validationResults.IsValid)
            {
                var failures = validationResults.Errors.ToList();
                var message = new StringBuilder();
                failures.ForEach(f => message.AppendLine(f.ErrorMessage));
                throw new ValidationException(message.ToString());
            }

            Product? product = _context.Products.Where(p => p.Id == command.Id).SingleOrDefault();
            if (product == null)
                throw new NotFoundException(nameof(Product), command.Id);

            _context.ShoppingBasket.Items.Add(product, command.Quantity);
        }
    }
}
