using System;
using System.ComponentModel.DataAnnotations;

namespace Apolo.Domain.Models
{
    public class Users
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name of the user is obrigatory")]
        public string Name { get; set; }
    }
}
