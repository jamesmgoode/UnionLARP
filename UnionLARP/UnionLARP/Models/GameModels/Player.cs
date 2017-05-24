﻿using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.GameModels
{
    public class Player
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RefLevel { get; set; }
    }
}
