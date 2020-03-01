using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data.Models
{
    public class PersonAccountContexts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BookType { get; set; }

        [ForeignKey(nameof(RavenueBook))]
        public int RavenueBookId { get; set; }
        public virtual RevenueExpenditureBookContexts RavenueBook { get; set; }
    }
}
