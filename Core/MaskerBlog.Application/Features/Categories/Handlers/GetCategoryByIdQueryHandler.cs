using AutoMapper;
using MaskerBlog.Application.Base;
using MaskerBlog.Application.Contacts.Persistence;
using MaskerBlog.Application.Features.Categories.Queries;
using MaskerBlog.Application.Features.Categories.Results;
using MaskerBlog.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskerBlog.Application.Features.Categories.Handlers
{
    public class GetCategoryByIdQueryHandler(IRepository<Category> repository, IMapper mapper) :
        IRequestHandler<GetCategoryByIdQuery, BaseResult<GetCategoryByIdQueryResul>>
    {
        public async Task<BaseResult<GetCategoryByIdQueryResul>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await repository.GetByIdAsync(request.Id);
            if (category == null)
            {
               return BaseResult<GetCategoryByIdQueryResul>.Notfound("Category not found");  
            }

            var response = mapper.Map<GetCategoryByIdQueryResul>(category);

            return BaseResult<GetCategoryByIdQueryResul>.Success(response);
        }
    }
}
