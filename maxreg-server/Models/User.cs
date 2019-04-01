using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace maxreg_server.Models
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Username { get; set; }
        [StringLength(30)]
        [Required]
        public string Password { get; set; }
        [StringLength(30)]
        [Required]
        public string Firstname { get; set; }
        [StringLength(30)]
        [Required]
        public string Lastname { get; set; }
        public bool IsAdmin { get; set; } = false;
        public bool Active { get; set; } = true;

        public User()
        {

        }
    }
}
