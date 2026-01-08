using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MaskerBlog.Application.Contacts.Persistence;
using MaskerBlog.Persistence.Concrete;
using MaskerBlog.Persistence.Context;
using MaskerBlog.Persistence.Interceptors;
using MaskerBlog.Domain.Entities;

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
                options.UseLazyLoadingProxies();
            });

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                //Aynı andan birden fazla kullanıcının aynı emaili kullanmasını engelle.

            }).AddEntityFrameworkStores<AppDbContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

        }
    }
}
