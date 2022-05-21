using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCPrimerEjemplo.Models;

namespace MVCPrimerEjemplo.Data
{
    public class MVCPrimerEjemploContext : DbContext
    {
        public MVCPrimerEjemploContext (DbContextOptions<MVCPrimerEjemploContext> options)
            : base(options)
        {
        }

        public DbSet<MVCPrimerEjemplo.Models.Movie>? Movie { get; set; }
    }
}
