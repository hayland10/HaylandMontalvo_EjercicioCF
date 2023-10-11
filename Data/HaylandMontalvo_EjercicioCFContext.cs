using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HaylandMontalvo_EjercicioCF.Models;

namespace HaylandMontalvo_EjercicioCF.Data
{
    public class HaylandMontalvo_EjercicioCFContext : DbContext
    {
        public HaylandMontalvo_EjercicioCFContext (DbContextOptions<HaylandMontalvo_EjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<HaylandMontalvo_EjercicioCF.Models.Burger> Burger { get; set; } = default!;
    }
}
