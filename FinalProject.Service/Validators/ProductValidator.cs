
using FinalProject.Domain.Entities;
using FluentValidation;

namespace FinalProject.Service.Validators
{

    public class ProductValidator : AbstractValidator<Product>
    {

        //Validation Rules
        public ProductValidator()
        {

            RuleFor(p => p.Name).NotEmpty().WithMessage("Game Name is required.");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Game Description is required.");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Game Price is required.");
            RuleFor(p => p.Category).NotEmpty().WithMessage("Game Category is required.");

        }

    }

    public class AchivementsValidator : AbstractValidator<Achivement>
    {

        //Validation Rules
        public AchivementsValidator()
        {

            RuleFor(a => a.Name).NotEmpty().WithMessage("Achivement Name is required.");
            RuleFor(a => a.Description).NotEmpty().WithMessage("Achivement Description is required.");

        }

    }

}