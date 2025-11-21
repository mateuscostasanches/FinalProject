
using FinalProject.Domain.Entities;
using FluentValidation;

namespace FinalProject.Service.Validators
{

    public class CustomerValidator : AbstractValidator<Customer>
    {

        //Validation Rules
        public CustomerValidator()
        {

            RuleFor(c => c.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(c => c.Nickname).NotEmpty().WithMessage("Nickname is required.");
            RuleFor(c => c.Email).NotEmpty().WithMessage("Email is required.");
            RuleFor(C => C.Password).NotEmpty().WithMessage("Password is required.");

        }

    }

}