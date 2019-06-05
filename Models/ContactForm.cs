using System.ComponentModel.DataAnnotations;

namespace UFPCore.Models
{
    public class ContactForm
    {
        [Required]
         public string Name { get; set; }
        [EmailAddress, Required]
        public string Email { get; set; }
        public string Message { get; set; }
    }
}