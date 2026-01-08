using MaskerBlog.Application.Base;
using MediatR;

namespace MaskerBlog.Application.Features.Categories.Commands
{
    public record RemoveCategoryCommand(Guid Id) :  IRequest<BaseResult<bool>>;
    
}
