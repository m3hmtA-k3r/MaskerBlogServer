 
namespace MaskerBlog.API.Endpoints.Registation
{
    public static class EndpointRegistrations
    {
        public static void RegisterEndpoints(this IEndpointRouteBuilder app)
        {
            app.RegisterCategoryEndpoints();
            app.RegisterBlogEndPoints();
            app.RegisterUserEndPoints();
        }
    }
}
