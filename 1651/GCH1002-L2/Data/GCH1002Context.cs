using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GCH1002_L2.Models;

    public class GCH1002Context : DbContext
    {
        public GCH1002Context (DbContextOptions<GCH1002Context> options)
            : base(options)
        {
        }

        public DbSet<GCH1002_L2.Models.Ticket> Ticket { get; set; } = default!;
    }
