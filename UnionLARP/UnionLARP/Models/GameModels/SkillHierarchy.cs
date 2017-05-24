using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.GameModels
{
    public class SkillHierarchy
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int ParentId { get; set; }
    }
}
