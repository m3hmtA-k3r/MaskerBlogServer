using MaskerBlog.Application.Base;

namespace MaskerBlog.Application.Features.Categories.Results
{
    public class GetCategoryByIdQueryResul: BaseDto
    {
        public string CategoryName { get; set; }
        //public IList<GetBlogQueryResult> Blogs { get; set; } //Blogun Kategorisine göre birden fazla blog olabilir.
    }
}
