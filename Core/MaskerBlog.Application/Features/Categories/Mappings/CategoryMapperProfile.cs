using AutoMapper;
using MaskerBlog.Application.Features.Categories.Results;
using MaskerBlog.Domain.Entities;

namespace MaskerBlog.Application.Features.Categories.Mappings
{
    public class CategoryMapperProfile : Profile
    {
        public CategoryMapperProfile()
        {
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
        }
    }
}
