using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Domain.Models
{
    public class MenuItem
    {
        [Key]
        public Guid id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public Guid MenuId { get; set; }
        public Menu? Menu { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
        public List<Table>? Tables { get; set; }
        public string? Category { get; set; }
    }
}
