

using FluentValidation;
using FinalProject.Domain.Entities;

namespace FinalProject.Service.Validators
{

    public class SaleValidator : AbstractValidator<Sale>
    {

        #region validation
        public SaleValidator()
        {

            RuleFor(c => c.Customer)
                .NotEmpty().WithMessage("Customer is required.");

            RuleFor(c => c.SaleItems)
                .NotEmpty().WithMessage("Product is required.");

        }
        #endregion 

    }

    public class SaleItemValidator : AbstractValidator<SaleItem>
    {

        #region validation
        public SaleItemValidator()
        {

            RuleFor(c => c.Product)
                .NotNull().WithMessage("Product is required");

            RuleFor(c => c.UnitPrice)
                .NotEmpty().WithMessage("Unit Price is required.")
                .GreaterThan(0).WithMessage("Unit price must be greater than zero.");

            RuleFor(c => c.Developer)
                .NotEmpty().WithMessage("Developer is required.");
        }
        #endregion 

    }

}