using AutoMapper;
using MaskerBlog.Application.Features.Categories.Commands;
using MaskerBlog.Application.Features.Categories.Results;
using MaskerBlog.Domain.Entities;

namespace MaskerBlog.Application.Features.Categories.Mappings
{
    public class CategoryMapperProfile : Profile
    {
        public CategoryMapperProfile()
        {
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, GetCategoryByIdQueryResul>().ReverseMap(); 
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();  
        }
    }
}
