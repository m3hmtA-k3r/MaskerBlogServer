using FluentValidation;
using MaskerBlog.Application.Features.Categories.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskerBlog.Application.Features.Categories.Validators
{
    public class UpdateCategoryValidator : AbstractValidator<UpdateCategoryCommand>
    {
        public UpdateCategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategori Adı Zorunludur")
                .MinimumLength(3).WithMessage("Kategori adı en az 3 karakterden oluşmalıdır.");

            RuleFor(x => x.Id).NotEmpty().WithMessage("Kategori Id Gereklidir");
        }
    }
}
