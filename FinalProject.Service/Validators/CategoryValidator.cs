
using FluentValidation;
using FinalProject.Domain.Entities;

namespace FinalProject.Service.Validators
{

    public class CategoryValidator : AbstractValidator<Category>
    {

        #region validation
        public CategoryValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(20).WithMessage("Category Name can't exceed 20 characters.");

        }
        #endregion

    }

}
