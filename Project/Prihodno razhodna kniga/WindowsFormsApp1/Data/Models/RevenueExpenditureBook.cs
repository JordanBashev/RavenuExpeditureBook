using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.Data.Models
{
    /// <summary>
    /// Main RevenueExpenditureBook Class
    /// Countains variables used to create the table in database
    /// </summary>
    public class RevenueExpenditureBook
    {
        /// <summary>
        /// variable int
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Variable Datetime
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Variable decimal
        /// </summary>
        public decimal Income { get; set; }

        /// <summary>
        /// Variable decimal
        /// </summary>
        public decimal RawMaterials { get; set; }

        /// <summary>
        /// Variable decimal
        /// </summary>
        public decimal Expense { get; set; }

        /// <summary>
        /// Variable decimal
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Variable decimal
        /// </summary>
        public decimal Counted { get; set; }

        /// <summary>
        /// Variable decimal
        /// </summary>
        public decimal CheckOutPlusAndMinus { get; set; }

        //Reference with PersonBookType Table
        /// <summary>
        /// Reference with PersonBookType Table
        /// </summary>
        [ForeignKey(nameof(PersonBookType))]
        public int AccountRavenueBookId { get; set; }
        /// <summary>
        /// Reference with PersonBookType Table
        /// </summary>
        public virtual PersonBookType PersonBookType { get; set; }

        //Reference with PersonRegister Table 
        /// <summary>
        /// Reference with PersonRegister Table
        /// </summary>
        [ForeignKey(nameof(UserRegisterId))]
        public int UserRegisteredId { get; set; }
        /// <summary>
        /// Reference with PersonRegister Table
        /// </summary>
        public virtual PersonRegister UserRegisterId { get; set; }
    }
}
