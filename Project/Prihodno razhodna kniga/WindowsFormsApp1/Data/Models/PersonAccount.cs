using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.Data.Models
{
    /// <summary>
    /// Main PersonAccount Class
    /// Countains variables used to create the table in database
    /// </summary>
    public class PersonAccount
    {
        /// <summary>
        /// variable int
        /// </summary>
        [Key]
        public int PersonRegistersId { get; set; }

        //Reference with PersonBookType Table
        /// <summary>
        /// Reference with PersonBookType Table
        /// </summary>
        [ForeignKey(nameof(PersonBook))]
        public int PersonBookTypesId { get; set; }
        /// <summary>
        /// Reference with PersonBookType Table
        /// </summary>
        public virtual PersonBookType PersonBook { get; set; }
    }
}
