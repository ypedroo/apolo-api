﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Apolo.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name of the user is obrigatory")]
        public string Name { get; set; }
    }
}
