using MediatR;

namespace Apolo.Domain.Core.Commands
{
    public abstract class CommandBase : IRequest<CommandResult>
    {
        public abstract bool IsValid { get; }
    }
}