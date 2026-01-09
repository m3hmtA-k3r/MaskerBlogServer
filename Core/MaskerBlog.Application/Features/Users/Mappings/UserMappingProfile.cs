using AutoMapper;
using MaskerBlog.Application.Features.Users.Commands;
using MaskerBlog.Domain.Entities;

namespace MaskerBlog.Application.Features.Users.Mappings
{
    public class UserMappingProfile: Profile
    {
        public UserMappingProfile()
        {
            CreateMap<AppUser, CreateUserCommand>().ReverseMap();
        }
    }
}
