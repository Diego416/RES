using System.ComponentModel.DataAnnotations;

namespace SampleMvcApp.ViewModels
{
    public class SignUpViewModel
    {
        [Required]
        //[ID]
        [Display(Name = "Identification")]
        public string ID { get; set; }

        [Required]
        //[Name]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        //[LastName]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}