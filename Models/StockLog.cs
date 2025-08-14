using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagementSystem.Models
{
    public class StockLog
    {
        [Key]
        public int StockLogId { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int QuantityChanged { get; set; }

        [StringLength(50)]
        public string ActionType { get; set; } // Import, Sale, Adjustment

        public DateTime ActionDate { get; set; } = DateTime.Now;
    }
}
