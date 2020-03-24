using System;
using System.ComponentModel.DataAnnotations;
using Apolo.Domain.Core.Models;

namespace Apolo.Domain.Models
{
    public class Users : Entity
    {
        public Users(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }                
        public string Name { get; set; }
    }
}
