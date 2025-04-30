using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Image
    {
            public int Id { get; set; }
            public string? Url { get; set; } // כתובת התמונה

            //[ForeignKey("Travel")]
            //public int? TravelId { get; set; } // מפתח זר
            public virtual Travel? Travel { get; set; } // קשר חזרה ל-Travel
        
    }
}
