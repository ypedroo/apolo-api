using System;
using System.Threading;
using System.Threading.Tasks;
using Apolo.Domain.Commands;
using Apolo.Domain.Core.Commands;
using Apolo.Domain.Interfaces;
using Apolo.Domain.Models;
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
            try
            {
                var newSong = new Songs(
                    request.Name,
                    request.LikedBy
                );

                _unityOfWork.songRepository.Add(newSong);

                return CommandResult.Success();
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}