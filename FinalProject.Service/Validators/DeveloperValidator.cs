
using FinalProject.Domain.Entities;
using FluentValidation;

namespace FinalProject.Service.Validators
{

    public class DeveloperValidator : AbstractValidator<Developer>
    {

        //Validation Rules
        public DeveloperValidator()
        {

            RuleFor(d => d.Name).NotEmpty().WithMessage("Developer Name is required.");
            RuleFor(d => d.Email).NotEmpty().WithMessage("Email is required.");
            RuleFor(d => d.Password).NotEmpty().WithMessage("Password is required.");

        }
    }

}