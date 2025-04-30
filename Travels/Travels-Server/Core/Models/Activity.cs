using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public virtual Location? Location { get; set; }
        public virtual Attraction? Attraction { get; set; }
        public virtual Day? Day { get; set; }
        public Activity() { }
    }
}
