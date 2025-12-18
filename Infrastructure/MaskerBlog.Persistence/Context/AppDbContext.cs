using MaskerBlog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MaskerBlog.Persistence.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        #region Entity listesi için DbSet tanımlamaları
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Sosial> Sosials { get; set; }
        #endregion

    }

}


