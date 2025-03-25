using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Domain.Models
{
    public class Table
    {
        [Key]
        public Guid id { get; set; }
        public string? TableNumber { get; set; }

        public Guid RestorauntManagerId { get; set; }
        public RestorauntManager? RestorauntManager { get; set; }
        
        public Guid WaiterId { get; set; }
        public Waiter? Waiter { get; set; }
        public List<MenuItem>? MenuItems { get; set; }

    }
}
