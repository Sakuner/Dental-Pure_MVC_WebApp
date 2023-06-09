﻿using System.ComponentModel.DataAnnotations;

namespace Dental_Pure.Entities
{
    public class ServiceModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0,100000)]
        public double Price { get; set; }
    }
}
