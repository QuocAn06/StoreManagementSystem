using System.ComponentModel.DataAnnotations;

namespace StoreManagementSystem.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Category { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;


        // Navigation
        public ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
        public ICollection<StockLog> StockLogs { get; set; }
    }
}
