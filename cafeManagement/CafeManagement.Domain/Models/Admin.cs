using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Domain.Models
{
    public class Admin
    {
        [Key]
        public Guid id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public List<RestorauntManager>? RestorauntManagers { get; set; }
    }
}
