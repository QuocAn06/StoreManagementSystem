using System.ComponentModel.DataAnnotations;

namespace StoreManagementSystem.Models
{
    public class SalesOrder
    {
        [Key]
        public int SalesOrderId { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public string CustomerName { get; set; }

        public decimal TotalAmount { get; set; }

        // Navigation
        public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
}
