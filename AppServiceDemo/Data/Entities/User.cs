﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AppServiceDemo.Data.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid GameSessionId { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
