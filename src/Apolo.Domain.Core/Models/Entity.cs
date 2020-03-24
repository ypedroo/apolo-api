using System;

namespace Apolo.Domain.Core.Models
{
    public abstract class Entity
    {
        public Guid Id {get; protected set;}
    }
}