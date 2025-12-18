using MaskerBlog.Domain.Entities.Common;

namespace MaskerBlog.Domain.Entities;

public class Category : BaseEntity
{
    public string CategoryName { get; set; }

    public IList<Blog> Blogs { get; set; } //Blogun Kategorisine göre birden fazla blog olabilir.

}
