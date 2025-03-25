using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Domain.Models
{
    public class Order
    {
        [Key]
        public Guid id { get; set; }
        public Guid TableId { get; set; }
        public Table? Table { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.Now;
        public bool isPaid { get; set; } = false;
        public List<OrderItem>? OrderItems { get; set; }
    }
}
