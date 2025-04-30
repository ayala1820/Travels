using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Attraction
    {
        public int Id { get; set; }
        public string? Name  { get; set; }
        public string? Icon { get; set; }
        public virtual ICollection<Activity>? Activities { get; set; } 
        public Attraction() { }
    }
}
