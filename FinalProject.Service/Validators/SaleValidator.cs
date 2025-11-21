
using FinalProject.Domain.Entities;
using FluentValidation;

namespace FinalProject.Service.Validators
{

    public class SaleValidator : AbstractValidator<Sale>
    {

        //Validation Rules
        public SaleValidator()
        {

            RuleFor(c => c.Customer).NotEmpty().WithMessage("Customer is required.");
            RuleFor(c => c.Developer).NotEmpty().WithMessage("Developer is required.");
            RuleFor(c => c.SaleItems).NotEmpty().WithMessage("Product is required.");

        }

    }

}