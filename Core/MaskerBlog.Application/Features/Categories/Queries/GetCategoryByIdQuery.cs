using MaskerBlog.Application.Base;
using MaskerBlog.Application.Features.Categories.Results;
using MediatR;

namespace MaskerBlog.Application.Features.Categories.Queries
{
    public record GetCategoryByIdQuery(Guid Id): IRequest<BaseResult<GetCategoryByIdQueryResul>>
    {
    }
}
