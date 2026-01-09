using AutoMapper;
using MaskerBlog.Application.Features.Blog.Results;
using MaskerBlog.Domain.Entities;

namespace MaskerBlog.Application.Features.Blog.Mappings
{
    public class BlogMappingProfile: Profile
    {
        public BlogMappingProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<MaskerBlog.Domain.Entities.Blog, GetBlogsQueryResultTumBloklar>().ReverseMap();

        }
    }
}
