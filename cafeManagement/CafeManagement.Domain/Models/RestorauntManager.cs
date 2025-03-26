using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Domain.Models
{
    public class RestorauntManager
    {
        [Key]
        public Guid id { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }

        public string? RestorauntName { get; set; }
        public string? RestorauntLocation { get; set; }

        public Menu? Menu { get; set; }
        public List<Table>? Tables { get; set; }
        public List<Waiter>? Waiters { get; set; }
        
    }
}
