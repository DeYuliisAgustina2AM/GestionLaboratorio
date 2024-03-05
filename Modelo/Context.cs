using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Context : DbContext
    {
        public DbSet<Sede> Sedes { get; set; } // Tabla de sedes
        public DbSet<Laboratorio> Laboratorios { get; set;} // Tabla de laboratorios
        public DbSet<Computadora> Computadoras { get; set; } // Tabla de computadoras
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SistemaGestion;Integrated Security=true;TrustServerCertificate=true");

        }

        //relaciones entre las tablas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Una sede tiene de 0 a muchos laboratorios
            modelBuilder.Entity<Sede>()
                .HasMany(s => s.Laboratorios)
                .WithOne(l => l.sede)
                .HasForeignKey(l => l.SedeId);

            //Un laboratorio tiene de 0 a muchas computadoras
            modelBuilder.Entity<Laboratorio>()
                .HasMany(l => l.Computadoras)
                .WithOne(c => c.laboratorio)
                .HasForeignKey(c => c.LaboratorioId);

            //una computadora tiene un ticket
            modelBuilder.Entity<Computadora>()
                .HasOne(c => c.Ticket)
                .WithOne(t => t.computadora)
                .HasForeignKey<Ticket>(t => t.ComputadoraId);


        }
    }
}
