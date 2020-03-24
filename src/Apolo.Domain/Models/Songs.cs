using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apolo.Domain.Models
{
    public class Songs
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Users> LikedBy { get; set; }
    }
}
