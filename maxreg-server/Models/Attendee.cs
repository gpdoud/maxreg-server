using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace maxreg_server.Models
{
    public class Attendee
    {
        public int Id { get; set; }

        [Required]
        public int GuestId { get; set; }

        [Required]
        public int EventId { get; set; }
                
        public bool Active { get; set; } = true;

        public virtual Guest Guest { get; set; }
        public virtual Event Event { get; set; }

        public Attendee()
        {

        }
    }
}
