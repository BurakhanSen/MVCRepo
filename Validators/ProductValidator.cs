using FluentValidation;
using MVCTest.Models;

namespace MVCTest.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name cannot be null.");
            RuleFor(t => t.Category).MaximumLength(50)
                .WithMessage("Length of the category name cannot be bigger than 50 characters.");
        }
           
    }
}