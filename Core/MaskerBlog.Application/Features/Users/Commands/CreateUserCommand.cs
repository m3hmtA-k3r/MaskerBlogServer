using MaskerBlog.Application.Base;
using MediatR;

namespace MaskerBlog.Application.Features.Users.Commands
{
    public class CreateUserCommand: IRequest<BaseResult<object>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
