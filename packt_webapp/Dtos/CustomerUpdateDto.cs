﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace packt_webapp.Dtos
{
    public class CustomerUpdateDto
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
    }
}
