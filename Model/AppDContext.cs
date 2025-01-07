using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace ProvaFinal2.Model
{
    public class AppDContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
