using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1.Data.Models
{
    /// <summary>
    /// Main PersonRegister Class
    /// Countains variables used to create the table in database
    /// </summary>
    public class PersonRegister
    {
        /// <summary>
        /// variable int
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// variable string
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// variable string
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
