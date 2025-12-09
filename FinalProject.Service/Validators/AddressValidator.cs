
using FluentValidation;
using FinalProject.Domain.Entities;

namespace FinalProject.Service.Validators
{

    public class AddressValidator : AbstractValidator<Address>
    {

        #region validation
        public AddressValidator()
        {

            RuleFor(a => a.State)
                .NotEmpty().WithMessage("State is required.")
                .MaximumLength(50).WithMessage("State Name can't exceed 50 characters.");
            RuleFor(a => a.City)
                .NotEmpty().WithMessage("City is required.")
                .MaximumLength(50).WithMessage("City name can't exceed 50 characters.");

        }
        #endregion 

    }

}