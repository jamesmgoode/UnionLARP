﻿using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.GameModels
{
    public class Skill
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
