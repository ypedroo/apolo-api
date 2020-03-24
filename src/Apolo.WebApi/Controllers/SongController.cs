using System.Threading.Tasks;
using Apolo.Domain.Commands;
using Apolo.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Apolo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : CustomController
    {
        private readonly ISongRepository _songRepository;

        public SongController(IMediator mediator, ISongRepository songRepository) : base(mediator)
            => _songRepository = songRepository;

        [HttpPost("create")]
        public async Task<ActionResult> CreateSong(CreateSongCommand createSongCommand)
            => await SendCommand(createSongCommand);
    }
}