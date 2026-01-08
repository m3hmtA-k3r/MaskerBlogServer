using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MaskerBlog.Application.Contacts.Persistence;
using MaskerBlog.Persistence.Concrete;
using MaskerBlog.Persistence.Context;
using MaskerBlog.Persistence.Interceptors;

namespace MaskerBlog.Persistence.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(name: "SqlConnection"));
                options.AddInterceptors(new AuditDbContextInterceptor());
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

        }
    }
}
