using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Domain.Models
{
    public class Waiter
    {
        [Key]
        public Guid id { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public Guid RestorauntManagerId { get; set; }
        public RestorauntManager? RestorauntManager { get; set; }

        public List<Table>? Tables { get; set; }
    }
}
