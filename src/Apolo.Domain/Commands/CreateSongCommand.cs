using System;
using System.Collections.Generic;
using Apolo.Domain.Models;
using Apolo.Domain.Core.Commands;
using Flunt.Validations;
namespace Apolo.Domain.Commands
{
    public class CreateSongCommand : CommandBase
    {
        public string Name { get; set; }
        // public IEnumerable<Users> LikedBy { get; set; }

        public override void Validate() => AddNotifications(new Contract()
                    .HasMaxLen(Name, 40, "Name", "Name should have no more than 40 chars")
                    .HasMinLen(Name, 3, "Name", "Name should have at least 3 chars")
                );
    }
}