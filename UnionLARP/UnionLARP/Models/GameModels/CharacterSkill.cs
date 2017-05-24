using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.GameModels
{
    public class CharacterSkill
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int SkillId { get; set; }
    }
}
