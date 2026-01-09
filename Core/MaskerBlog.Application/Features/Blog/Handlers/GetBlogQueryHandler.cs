using AutoMapper;
using MaskerBlog.Application.Base;
using MaskerBlog.Application.Contacts.Persistence;
using MaskerBlog.Application.Features.Blog.Queries;
using MaskerBlog.Application.Features.Blog.Results;
using MediatR;

namespace MaskerBlog.Application.Features.Blog.Handlers
{
    public class GetBlogQueryHandler(IRepository<MaskerBlog.Domain.Entities.Blog> _repository, IMapper _mapper) : IRequestHandler<GetBlogQuery, BaseResult<List<GetBlogsQueryResultTumBloklar>>>
    {
        public async Task<BaseResult<List<GetBlogsQueryResultTumBloklar>>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            var blogs = _mapper.Map<List<GetBlogsQueryResultTumBloklar>>(values);

            return BaseResult<List<GetBlogsQueryResultTumBloklar>>.Success(blogs);
        }
    }
}
