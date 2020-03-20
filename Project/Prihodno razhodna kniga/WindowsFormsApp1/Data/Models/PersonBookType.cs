using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data.Models
{
    public class PersonBookType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BookType { get; set; }

        [ForeignKey(nameof(Accounts))]
        public int PersonAccountId { get; set; }
        public virtual PersonAccount Accounts { get; set; }
    }
}
