using AutoMapper;
using MaskerBlog.Application.Base;
using MaskerBlog.Application.Contacts.Persistence;
using MaskerBlog.Application.Features.Categories.Queries;
using MaskerBlog.Application.Features.Categories.Results;
using MaskerBlog.Domain.Entities;
using MediatR;

namespace MaskerBlog.Application.Features.Categories.Handlers
{
    public class GetCategoryQueryHandler(IRepository<Category> _repository, IMapper _mapper ) : 
        IRequestHandler<GetCategoryQuery, BaseResult<List<GetCategoryQueryResult>>>
    {
        public async Task<BaseResult<List<GetCategoryQueryResult>>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = await _repository.GetAllAsync();

            var response = _mapper.Map<List<GetCategoryQueryResult>>(categories);

            return BaseResult<List<GetCategoryQueryResult>>.Success(response);
        }
    }
}
