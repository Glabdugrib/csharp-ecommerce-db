using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_ecommerce_db
{
    [Table("order")]
    internal class Order
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("amount")]
        public decimal Amount { get; set; }
        [Column("status")]
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public List<OrdersProducts> OrdersProducts { get; set; }

        public Order(int customerId, DateTime date, string status)
        {
            CustomerId = customerId;
            Date = date;
            Status = status;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\nId: {Id}");
            Console.WriteLine($"Customer id: {CustomerId}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Status: {Status}");
        }
    }
}
