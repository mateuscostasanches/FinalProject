
using FinalProject.Domain.Entities;
using FluentValidation;

namespace FinalProject.Service.Validators
{

    public class AddressValidator : AbstractValidator<Address>
    {
        //Validation Rules
        public AddressValidator()
        {

            RuleFor(a => a.Country).NotEmpty().WithMessage("Country is required.");
            RuleFor(a => a.State).NotEmpty().WithMessage("State is required.");
            RuleFor(a => a.City).NotEmpty().WithMessage("City is required.");

        }

    }

}