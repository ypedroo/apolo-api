using System;
using Apolo.Domain.Core.Commands;
using Flunt.Validations;

namespace Apolo.Domain.Commands
{
    public class CreateUserCommand : CommandBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public override void Validate() => AddNotifications(new Contract()
            .IsNotEmpty(Id, nameof(Id), $"{nameof(Id)} can't be empty")
            .HasMaxLen(Name, 40, "Name", "Name should have no more than 40 chars")
            .HasMinLen(Name, 3, "Name", "Name should have at least 3 chars")
        );
    }
}   
