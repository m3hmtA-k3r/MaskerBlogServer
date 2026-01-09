using MaskerBlog.Application.Base;
using MaskerBlog.Application.Features.Blog.Results;
using MediatR;

namespace MaskerBlog.Application.Features.Blog.Queries
{
    public record GetBlogQuery : IRequest<BaseResult<List<GetBlogsQueryResultTumBloklar>>>
    { 
    }
}