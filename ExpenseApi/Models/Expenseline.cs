using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ExpenseApi.Models {

    public class Expenseline {

        [Key]       
        public int Id { get; set; }

        public int Quantity { get; set; } = 1;
        
        public int ExpenseId { get; set; }
        [JsonIgnore]
        public virtual Expense? Expense { get; set; }

        public int ItemId { get; set; }
        public virtual Item? Item { get; set; }

    }
}
