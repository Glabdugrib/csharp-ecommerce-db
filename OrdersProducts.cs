using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_ecommerce_db
{
    [Table("orders_products")]
    internal class OrdersProducts
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("product_id")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        [Column("order_id")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [Required]
        [Column("quantity")]
        public int Quantity { get; set; }

        public OrdersProducts(int productId, int orderId, int quantity)
        {
            ProductId = productId;
            OrderId = orderId;
            Quantity = quantity;
        }
    }
}
