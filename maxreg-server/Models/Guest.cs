using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace maxreg_server.Models
{
    public class Guest
    {
        public int Id { get; set; }

        [StringLength(30)]
        [Required]
        public string Firstname { get; set; }

        [StringLength(30)]
        [Required]
        public string Lastname { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public virtual IList<Attendee> Attendees { get; set; }

        public bool Active { get; set; } = true;

        public Guest()
        {

        }

    }
}
