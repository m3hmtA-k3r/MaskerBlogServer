using MaskerBlog.Application.Base;
using MediatR;

namespace MaskerBlog.Application.Features.Categories.Commands
{
    public record UpdateCategoryCommand(Guid Id, string CategoryName): IRequest<BaseResult<bool>>
    {

    }
    
}
