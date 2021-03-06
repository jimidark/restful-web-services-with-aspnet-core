﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace packt_webapp.Entities
{
    public class PacktDbContext : DbContext
    {
        public PacktDbContext(DbContextOptions<PacktDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
