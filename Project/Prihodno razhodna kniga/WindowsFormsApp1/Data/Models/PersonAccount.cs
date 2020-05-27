using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.Data.Models
{
    public class PersonAccount
    {
        [Key]
        public int PersonRegistersId { get; set; }

        //Reference with PersonBookType Table
        [ForeignKey(nameof(PersonBook))]
        public int PersonBookTypesId { get; set; }
        public virtual PersonBookType PersonBook { get; set; }
    }
}
