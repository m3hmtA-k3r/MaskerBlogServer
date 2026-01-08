using AutoMapper;
using MaskerBlog.Application.Base;
using MaskerBlog.Application.Contacts.Persistence;
using MaskerBlog.Application.Features.Categories.Commands;
using MaskerBlog.Domain.Entities;
using MediatR;
using System.Runtime.InteropServices;

namespace MaskerBlog.Application.Features.Categories.Handlers
{
    public class CreateCategoryCommandHandler(IRepository<Category> _repository, IUnitOfWork _unitOfWork, IMapper 
        _mapper) : IRequestHandler<CreateCategoryCommand, BaseResult<bool>>
    {
        public async Task<BaseResult<bool>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            await _repository.CreateAsync(category);
            var result = await _unitOfWork.SaveChangesAsync();
            return result ? BaseResult<bool>.Success(result) : BaseResult<bool>.Fail("Category could not be Added");
        }
    }
}
