using System;
using System.Threading;
using System.Threading.Tasks;
using Apolo.Domain.Commands;
using Apolo.Domain.Core.Commands;
using Apolo.Domain.Interfaces;
using MediatR;

namespace Apolo.Domain.Handlers
{
    public class CreateSongCommandHandler : IRequestHandler<CreateSongCommand, CommandResult>
    {
        private readonly IUnitOfWork _unityOfWork;
        public CreateSongCommandHandler(IUnitOfWork unitOfWork)
        {
            _unityOfWork = unitOfWork;
        }

        public Task<CommandResult> Handle(CreateSongCommand request, CancellationToken cancellationToken)
            => CreateSong(request).AsTask;

        private CommandResult CreateSong(CreateSongCommand request)
        {
            throw new NotImplementedException();
        }
    }
}