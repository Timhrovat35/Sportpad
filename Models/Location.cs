﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportpad.Models
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Event[] Event { get; set; }
    }
}
