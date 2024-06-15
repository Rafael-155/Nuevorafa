using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Nuevorafa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Nuevorafa.Models.Contacto> DataContacto {get; set; }
        public DbSet<Nuevorafa.Models.Producto> Productos { get; set; }
        public DbSet<Nuevorafa.Models.Usuario> Usuarios { get; set; }
        public DbSet<Nuevorafa.Models.OrdenDetail> OrdenDetails { get; set; }
    }
}
