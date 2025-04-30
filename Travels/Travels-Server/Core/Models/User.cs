using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        //[Required]
        [StringLength(100)]
        public string? Name { get; set; }

        //[Required]
        [StringLength(100)]
        public string? Email { get; set; }
        public virtual Permission? Permission { get; set; }
        public virtual ICollection<Travel>? Travels { get; set; }
        public User() { }
    }
}
