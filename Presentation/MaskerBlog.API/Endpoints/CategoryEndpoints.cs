using MaskerBlog.Application.Features.Categories.Commands;
using MaskerBlog.Application.Features.Categories.Queries;
using MediatR;

namespace MaskerBlog.API.Endpoints
{
    public static class CategoryEndpoints
    {
        public static void RegisterCategoryEndpoints(this IEndpointRouteBuilder app)
        {
            var categories = app.MapGroup(prefix:"/categories").WithTags("Categories");

            categories.MapGet("", async (IMediator mediator) =>
            {
                var response = await mediator.Send(new GetCategoryQuery());
                return response.IsSuccess ? Results.Ok(response) : Results.BadRequest(response);
            });

            categories.MapPost(string.Empty, async (CreateCategoryCommand command, IMediator meditor) =>
            {
                var response = await meditor.Send(command);
                return response.IsSuccess ? Results.Ok(response) : Results.BadRequest(response);
            });

            categories.MapGet("{id}", async (Guid id, IMediator mediator) =>
            {
                var response = await mediator.Send(new GetCategoryByIdQuery(id));
                return response.IsSuccess ? Results.Ok(response) : Results.BadRequest(response);
            });

        }

    }
}
