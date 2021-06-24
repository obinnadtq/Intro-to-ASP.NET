﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
