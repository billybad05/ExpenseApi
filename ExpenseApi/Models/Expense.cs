using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseApi.Models { 

    public class Expense {

        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        public string Description { get; set; }

        [StringLength(10)]
        public string Status { get; set; } = "NEW";

        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; } = 0;

        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }

        public virtual ICollection<Expenseline>? Expenselines { get; set; }
    }
}
