using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data.Models
{
    public class RevenueExpenditureBook
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Income { get; set; }

        public decimal RawMaterials { get; set; }

        public decimal Expense { get; set; }

        public decimal Balance { get; set; }

        public decimal Counted { get; set; }

        public decimal CheckOutPlusAndMinus { get; set; }

        [ForeignKey(nameof(PersonBookType))]
        public int AccountRavenueBookId { get; set; }
        public virtual PersonBookType PersonBookType { get; set; }

        [ForeignKey(nameof(UserRegisterId))]
        public int UserRegisteredId { get; set; }
        public virtual PersonRegister UserRegisterId { get; set; }
    }
}
