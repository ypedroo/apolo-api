using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apolo.Domain.Models
{
    public class Songs
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Name of the song is obrigatory")]
        public string Name { get; set; }

        public IEnumerable<Users> LikedBy { get; set; }
    }
}
