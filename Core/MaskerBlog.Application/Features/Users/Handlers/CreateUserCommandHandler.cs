using AutoMapper;
using MaskerBlog.Application.Base;
using MaskerBlog.Application.Features.Users.Commands;
using MaskerBlog.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MaskerBlog.Application.Features.Users.Handlers
{
    public class CreateUserCommandHandler(UserManager<AppUser> _userManager, IMapper _mapper) : IRequestHandler<CreateUserCommand, BaseResult<object>>
    {
        public async Task<BaseResult<object>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            
            var user =  new AppUser
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.Username,
                Email = request.Email
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded)
            {
                return BaseResult<object>.Fail(result.Errors);
            }
            return BaseResult<object>.Success("User is created successfully");
        }
    }
}
