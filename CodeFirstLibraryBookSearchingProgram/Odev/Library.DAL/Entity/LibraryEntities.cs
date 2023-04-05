using Library.DAL.Configuraiton;
using Microsoft.EntityFrameworkCore;
using Odev.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Entity
{
    public class LibraryEntities:DbContext
    {
        public LibraryEntities()
        {

        }
        public LibraryEntities(DbContextOptions<LibraryEntities> options) : base(options)         
        {

        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(AppConfig.GetConnectionString());

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }

    }
}
