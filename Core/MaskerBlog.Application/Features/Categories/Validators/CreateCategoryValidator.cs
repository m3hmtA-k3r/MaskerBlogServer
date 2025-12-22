using FluentValidation;
using MaskerBlog.Application.Features.Categories.Commands;

namespace MaskerBlog.Application.Features.Categories.Validators
{
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Category Name is Required")
                .MinimumLength(3).WithMessage("Category Name must be at least 3 characters");
        }
    }
}
