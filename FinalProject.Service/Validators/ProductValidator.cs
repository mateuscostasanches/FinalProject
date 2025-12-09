

using FluentValidation;
using FinalProject.Domain.Entities;

namespace FinalProject.Service.Validators
{

    public class ProductValidator : AbstractValidator<Product>
    {

        #region validation
        public ProductValidator()
        {

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Game Name is required.")
                .MaximumLength(100).WithMessage("Game Name can't exceed 100 characters.");

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("Game Description is required.")
                .MaximumLength(250).WithMessage("Game Description can't exceed 250 characters.");
            
            RuleFor(p => p.Category)
                .NotEmpty().WithMessage("Game Category is required.");
            
            RuleFor(p => p.Developer)
                .NotEmpty().WithMessage("Game Developer is required.");
            
        }
        #endregion

    }

}