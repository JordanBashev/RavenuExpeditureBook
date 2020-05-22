using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1.Data.Models
{
    public class PersonBookType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BookType { get; set; }

        public int PersonAccountId { get; set; }
    }
}
