using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.GameModels
{
    public class Player
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DefaultValue("Player")]
        public string RefLevel { get; set; }
    }
}
