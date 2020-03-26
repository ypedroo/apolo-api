using System;
using System.Collections.Generic;
using Apolo.Domain.Core.Models;

namespace Apolo.Domain.Models
{
    public class Songs : Entity
    {
        public Songs(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }         
        public string Name { get; set; }

    }
}
