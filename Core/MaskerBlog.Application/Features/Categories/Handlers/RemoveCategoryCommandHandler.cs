using MaskerBlog.Application.Base;
using MaskerBlog.Application.Contacts.Persistence;
using MaskerBlog.Application.Features.Categories.Commands;
using MaskerBlog.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskerBlog.Application.Features.Categories.Handlers
{
    public class RemoveCategoryCommandHandler(IRepository<Category> repository, IUnitOfWork unitOfWork) : 
        IRequestHandler<RemoveCategoryCommand, BaseResult<bool>>
    {
        public async Task<BaseResult<bool>> Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await repository.GetByIdAsync(request.Id);
            if(category == null)
            {
                return BaseResult<bool>.Notfound("Kategori bulunamadı.");
            }

            repository.Delete(category);
            var response = await unitOfWork.SaveChangesAsync();

            return response
                ? BaseResult<bool>.Success(response) 
                : BaseResult<bool>.Fail("Kategori silinemedi.");
        }
    }
}
