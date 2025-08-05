using System.ComponentModel.DataAnnotations;

namespace Zee.Models
{
    public class Expense
    {
        [Key]
        public Guid ExpenseId { get; set; }
        [Required]
        public decimal Value { get; set; }
        public string? Description { get; set; }
    }
}
