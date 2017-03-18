using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class DBContext : DbContext
    {
        public DbSet<entradas> Entradas { get; set; }
        public DbSet<usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;database=db_res2;uid=root;pwd=root;");
    }
}