using System;
using System.ComponentModel.DataAnnotations;

namespace TakeHome.Models
{
    public class FeedbackViewModel // refactored to mvc naming convention
	{
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide First Name")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "First Name should be min 1 and max 25 length")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Last Name")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "First Name should be min 1 and max 25 length")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Email should be min 1 and max 25 length")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Comments")]
        [DataType(DataType.MultilineText)]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Comments should have a max length of 200")]
        public string Comments { get; set; }
	}
}