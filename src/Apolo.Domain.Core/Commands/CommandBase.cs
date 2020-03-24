using MediatR;
using Flunt.Validations;
using Flunt.Notifications;

namespace Apolo.Domain.Core.Commands
{
    public class CommandBase : Notifiable, IValidatable, IRequest<CommandResult>
    {
        public virtual void Validate(){}
    }
}