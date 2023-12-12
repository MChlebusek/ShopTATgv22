using System.ComponentModel.DataAnnotations;

namespace Shop.Models.Accounts
{
    public class AddPasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [Compare("NewPassword", ErrorMessage = "Password mismatch.")]
        public string ConfirmPassword { get; set; }
    }
}
