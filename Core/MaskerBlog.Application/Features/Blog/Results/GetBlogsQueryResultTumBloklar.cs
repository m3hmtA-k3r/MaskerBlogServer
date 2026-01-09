using MaskerBlog.Application.Base;

namespace MaskerBlog.Application.Features.Blog.Results;

public class GetBlogsQueryResultTumBloklar : BaseDto
{
    public string Title { get; set; }
    public string CoverImage { get; set; }
    public string BlogImage { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public GetBlogsQueryResultTumBloklar Category { get; set; }
    public string UserId { get; set; }
    //public AppUser User { get; set; }
    //public IList<Comment> Comments { get; set; } 
}
