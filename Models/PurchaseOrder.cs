using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagementSystem.Models
{
    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrderId { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public int SupplierId { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        public decimal TotalAmount { get; set; }


        // Navigation
        public ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
