using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParcialMVC.Models;

    public class Libreriacontext : DbContext
    {
        public Libreriacontext (DbContextOptions<Libreriacontext> options)
            : base(options)
        {
        }

        public DbSet<ParcialMVC.Models.Libro> Libro { get; set; } = default!;

        public DbSet<ParcialMVC.Models.Cliente> Cliente { get; set; } = default!;
    }
