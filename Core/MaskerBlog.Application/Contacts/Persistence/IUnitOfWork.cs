namespace MaskerBlog.Application.Contacts.Persistence
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
