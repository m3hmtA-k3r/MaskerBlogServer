using MaskerBlog.Domain.Entities.Common;

namespace MaskerBlog.Domain.Entities;

public class Sosial : BaseEntity
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
