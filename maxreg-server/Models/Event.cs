﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace maxreg_server.Models
{
    public class Event
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? Date { get; set; }

        public bool Active { get; set; } = true;

        public Event()
        {

        }

    }
}
