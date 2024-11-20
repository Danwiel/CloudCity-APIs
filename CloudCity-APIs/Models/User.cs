using System.ComponentModel.DataAnnotations;

namespace CloudCity_APIs.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "parameter must not be empty")]
        public string UserFullName { get; set; }

        [Required(ErrorMessage = "parameter must not be empty")]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "parameter must not be empty")]
        public string UserPassword { get; set; }
    }
}