using AutoMapper;
using MaskerBlog.Application.Base;
using MaskerBlog.Application.Contacts.Persistence;
using MaskerBlog.Application.Features.Categories.Commands;
using MaskerBlog.Domain.Entities;
using MediatR;

namespace MaskerBlog.Application.Features.Categories.Handlers
{
    public class UpdateCategoryCommandHandler(IRepository<Category> repository, IMapper mapper, IUnitOfWork unitOfWork) : 
        IRequestHandler<UpdateCategoryCommand, BaseResult<bool>>
    {
        public async Task<BaseResult<bool>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = mapper.Map<Category>(request);
            repository.Update(category);
            var response = await unitOfWork.SaveChangesAsync();

            return response 
                ? BaseResult<bool>.Success(response) 
                : BaseResult<bool>.Fail("Category could not Update");
        }
    }
}
