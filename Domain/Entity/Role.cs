﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Role : BaseEntity
    {
        public string? Code { get; set; }
        public required string Name { get; set; }
    }
}
