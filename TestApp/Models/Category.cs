﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Display Order for category must be greater than zero")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
