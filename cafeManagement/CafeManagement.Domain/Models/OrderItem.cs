using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Domain.Models
{
    public class OrderItem
    {
        [Key]
        public Guid id { get; set; }
        public int Quantity { get; set; }
        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
        public Guid MenuItemId { get; set; }
        public MenuItem? MenuItem { get; set; }

    }
}
