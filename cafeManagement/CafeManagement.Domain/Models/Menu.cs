using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Domain.Models
{
    public class Menu
    {
        [Key]
        public Guid id { get; set; }
        public Guid RestorauntManagerId { get; set; }
        public RestorauntManager? RestorauntManager { get; set; }
        public List<MenuItem>? MenuItems { get; set; }
      


    }
}
