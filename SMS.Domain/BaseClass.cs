﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain
{
    public class BaseClass
    {
        public DateTime? DateAdded { get; set; } //nullable
        public string? AddedBy { get; set; }
    }
}
