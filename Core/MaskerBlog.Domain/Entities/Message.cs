using MaskerBlog.Domain.Entities.Common;

namespace MaskerBlog.Domain.Entities;

public class Message : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string MessageContent { get; set; }
    public bool IsRead { get; set; }
}
