using _2.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DATA.Context
{
    public class FastFoodDbContext: DbContext
    {
        public FastFoodDbContext()
        {

        }
        public FastFoodDbContext(DbContextOptions<FastFoodDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Data Source=NUGETRENKI\SQLEXPRESS;Initial Catalog=ASS_NET106;Integrated Security=True"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration()
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
