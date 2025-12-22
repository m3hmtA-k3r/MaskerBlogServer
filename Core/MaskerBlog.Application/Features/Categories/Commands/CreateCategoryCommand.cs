using MaskerBlog.Application.Base;
using MediatR;

namespace MaskerBlog.Application.Features.Categories.Commands
{
    public record CreateCategoryCommand(string CategoryName) : IRequest<BaseResult<bool>>;



}
