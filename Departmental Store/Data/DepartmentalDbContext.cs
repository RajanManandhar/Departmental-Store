using Departmental_Store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Departmental_Store.Data
{
    public class DepartmentalDbContext : DbContext
    {
        public DepartmentalDbContext(DbContextOptions<DepartmentalDbContext> options) : base(options)
        { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; } 
        public DbSet<Item> Items { get; set; }
        public DbSet<Tpin> Tpins { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
