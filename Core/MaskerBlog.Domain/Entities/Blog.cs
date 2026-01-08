using MaskerBlog.Domain.Entities.Common;

namespace MaskerBlog.Domain.Entities;

public class Blog: BaseEntity
{
    public string Title { get; set; }
    public string CoverImage { get; set; }
    public string BlogImage { get; set; }
    public string Description { get; set; }

    public Guid CategoryId { get; set; }
    public virtual Category Category { get; set; }
    //Her Blogta sadece bir kategori olabilir.

    public string UserId { get; set; } // Her bir Blogun bir yazarı olması gerekir.
    public virtual AppUser User { get; set; }

}
