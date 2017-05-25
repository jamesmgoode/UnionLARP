using System.Collections.Generic;
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
        public bool IsAlive { get; set; }
        [Required]
        public string Race { get; set; }
        [Display(Name = "Elemental Stance")]
        public string ElementalStance { get; set; }        
        public int? SpecialPowerId { get; set; }

        public static Character GetCurrentCharacter(IEnumerable<Character> characters)
        {
            foreach(var character in characters)
            {
                if (character.IsAlive)
                {
                    return character;
                }
            }

            return null;
        }
    }
}
