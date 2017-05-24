using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.GameModels
{
    public class Character
    {
        public int Id { get; set; }
        [Required]
        public string PlayerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Race { get; set; }
        public string ElementalStance { get; set; }
    }
}
