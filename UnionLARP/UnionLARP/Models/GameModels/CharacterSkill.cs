using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.GameModels
{
    public class CharacterSkill
    {
        public int Id { get; set; }
        [Required]
        public int CharacterId { get; set; }
        [Required]
        public int SkillId { get; set; }
    }
}
