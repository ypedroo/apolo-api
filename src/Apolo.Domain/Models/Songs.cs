using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Apolo.Domain.Core.Models;

namespace Apolo.Domain.Models
{
    public class Songs : Entity
    {
        public Songs(string name, IEnumerable<Users> likedBy)
        {
            Id = Guid.NewGuid();
            Name = name;
            LikedBy = likedBy;
        }         
        public string Name { get; set; }

        public IEnumerable<Users> LikedBy { get; set; }
    }
}
