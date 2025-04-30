using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Core.Models
{
    public class Travel
    {
        [Key]
        public int Id { get; set; }

        public DateTime? StartDay { get; set; }

        public DateTime? FinishDay { get; set; }

        public virtual Location? Location { get; set; } // הנחה ש-Location היא מחלקה קיימת

        public ICollection<Day>? Days { get; set; } // הנחה ש-Day היא מחלקה קיימת

        public double? Price { get; set; }

        public virtual List<string> Images { get; set; }
        public Travel() { }
    }
}
