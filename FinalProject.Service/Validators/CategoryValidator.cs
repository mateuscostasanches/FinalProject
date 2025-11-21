
using FinalProject.Domain.Entities;
using FluentValidation;

namespace FinalProject.Service.Validators
{

    public class CategoryValidator : AbstractValidator<Category>
    {

        //Validation Rules
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Name is required.");

        }

    }

}
