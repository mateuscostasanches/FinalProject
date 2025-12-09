
using FluentValidation;
using FinalProject.Domain.Entities;

namespace FinalProject.Service.Validators
{

    public class CustomerValidator : AbstractValidator<Customer>
    {

        #region validation
        public CustomerValidator()
        {

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Your Name is required!")
                .MaximumLength(100).WithMessage("Your Name can't exceed 100 characters.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Your Email is required!")
                .MaximumLength(100).WithMessage("Your Email can't exceed 100 characters.")
                .EmailAddress()
                .WithMessage("Please enter a valid email address.");

            RuleFor(C => C.Password)
                .NotEmpty().WithMessage("Your Password is required.")
                .MinimumLength(5).WithMessage("Your Password must have at least 5 caracteres.")
                .MaximumLength(50).WithMessage("Your Password can't exceed 50 characters.")
                .Matches(@"[\*\.\@\$\%\&\#]+").WithMessage("Your password must contain at least one symbol (@#$%&*.).")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");
        }
        #endregion 

    }

}
