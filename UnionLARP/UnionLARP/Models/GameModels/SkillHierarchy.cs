using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.GameModels
{
    public class SkillHierarchy
    {
        public int Id { get; set; }
        [Required]
        public int ChildId { get; set; }
        [Required]
        public int ParentId { get; set; }
    }
}
