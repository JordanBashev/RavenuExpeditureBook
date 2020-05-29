using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1.Data.Models
{
    /// <summary>
    /// Main PersonBookType Class
    /// Countains variables used to create the table in database
    /// </summary>
    public class PersonBookType
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
        public string BookType { get; set; }

        /// <summary>
        /// variable int
        /// </summary>
        public int PersonAccountId { get; set; }
    }
}
