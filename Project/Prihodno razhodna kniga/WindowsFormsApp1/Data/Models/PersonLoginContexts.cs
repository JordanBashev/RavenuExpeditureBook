using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.Data.Models
{
    public class PersonLoginContexts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        //public DateTime DeletedOn { get; set; }

        [ForeignKey(nameof(PersonAccount))]
        public int PersonAccountId { get; set; }
        public virtual PersonAccountContexts PersonAccount { get; set; }

    }
}
