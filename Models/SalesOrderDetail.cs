using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagementSystem.Models
{
    public class SalesOrderDetail
    {
        [Key]
        public int SalesOrderDetailId { get; set; }

        public int SalesOrderId { get; set; }

        [ForeignKey("SalesOrderId")]
        public SalesOrder SalesOrder { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
