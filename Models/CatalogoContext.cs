using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace catologoEm3.Models
{
    public class CatalogoContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Cliente> Ciente { get; set; }
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<Pecas> Pecas { get; set; }

        public CatalogoContext(DbContextOptions<CatalogoContext> options) : base(options) {

        }

    }

}