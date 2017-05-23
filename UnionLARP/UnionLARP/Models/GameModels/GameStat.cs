using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.GameModels
{
    public class GameStat
    {
        [Key]
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
