using MaskerBlog.Application.Features.Users.Commands;
using MediatR;

namespace MaskerBlog.API.Endpoints
{
    public static class UserEndPoints
    {
        public static void RegisterUserEndPoints(this IEndpointRouteBuilder app)
        {
            var users = app.MapGroup(prefix:"/users").WithTags("Users");

            users.MapPost(pattern: "register", async (IMediator mediator, CreateUserCommand command) =>
            {
                var response = await mediator.Send(command);
                return response.IsSuccess ? Results.Ok(response) : Results.BadRequest(response);
            });

        }
    }
}
