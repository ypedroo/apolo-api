using System;
using System.ComponentModel.DataAnnotations;

namespace Apolo.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }
    }
}
