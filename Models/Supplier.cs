using System.ComponentModel.DataAnnotations;

namespace StoreManagementSystem.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }


        // Navigation
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
