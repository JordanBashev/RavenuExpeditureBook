using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1.Data.Models
{
    public class PersonRegister
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
