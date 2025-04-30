using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public virtual ICollection<Travel> Travels { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public Location() { }
    }
}
