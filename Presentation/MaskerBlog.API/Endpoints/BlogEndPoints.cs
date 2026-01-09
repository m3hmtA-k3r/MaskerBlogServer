using MaskerBlog.Application.Features.Blog.Queries;
using MediatR;

namespace MaskerBlog.API.Endpoints
{
    public static class BlogEndpoints
    {
        public static void RegisterBlogEndPoints(this IEndpointRouteBuilder app)
        {
            var blogs = app.MapGroup(prefix: "/blogs").WithTags("Blogs");

            blogs.MapGet(pattern: string.Empty,
                async (IMediator _mediator) =>
                {
                    var response = await _mediator.Send(new GetBlogQuery());
                    return response.IsSuccess ? Results.Ok(response) : Results.BadRequest(response);
                });
        }
    }
}
