using System;
using System.Linq;
using Apolo.Domain.Core.Models;

namespace Apolo.Domain.Models
{
    public class Songs : Entity
    {
        public Songs(string name, IQueryable<Users> likedBy)
        {
            Id = Guid.NewGuid();
            Name = name;
            LikedBy = likedBy;
        }         
        public string Name { get; set; }

        public IQueryable<Users> LikedBy { get; set; }
    }
}
