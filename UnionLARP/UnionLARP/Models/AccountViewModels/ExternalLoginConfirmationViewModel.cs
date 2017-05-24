using System.ComponentModel.DataAnnotations;

namespace UnionLARP.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Player Name")]
        public string PlayerName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
