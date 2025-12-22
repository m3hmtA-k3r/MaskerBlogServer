using MaskerBlog.Application.Contacts.Persistence;
using MaskerBlog.Persistence.Context;

namespace MaskerBlog.Persistence.Concrete
{
    public class UnitOfWork(AppDbContext _context) : IUnitOfWork
    {
        public async Task<bool> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync() > 0;
        }
    }
}
