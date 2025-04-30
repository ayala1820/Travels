using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Day
    {
        public int Id { get; set; }
        public DateTime? Name { get; set; }
        public virtual ICollection<Activity>? Activities { get; set; }
        public Day() { }
    }
}
