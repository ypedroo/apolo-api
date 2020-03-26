using System.Threading.Tasks;
using Apolo.Domain.Commands;
using Apolo.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Apolo.WebApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UserController : CustomController
    {
        private readonly IUserRepository _userRepository;
        public UserController(IMediator mediator, IUserRepository userRepository) : base(mediator)
            => _userRepository = userRepository;

        [HttpPost("create")]
        public async Task<ActionResult> CreateUser(CreateUserCommand createUserCommand)
            => await SendCommand(createUserCommand);
    }
}