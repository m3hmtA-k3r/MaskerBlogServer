using MaskerBlog.Application.Base;
using MaskerBlog.Domain.Entities;

namespace MaskerBlog.Application.Features.Categories.Results
{
    public class GetCategoryQueryResult: BaseDto
    {
        public string CategoryName { get; set; }
        //public IList<GetBlogQueryResult> Blogs { get; set; } //Blogun Kategorisine göre birden fazla blog olabilir.
    }
}
