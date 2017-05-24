using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.GameModels
{
    public class SpecialPower
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
