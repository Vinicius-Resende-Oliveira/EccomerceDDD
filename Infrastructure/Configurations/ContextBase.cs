using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configurations
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionBuilder);
            }
        }

        private string GetStringConectionConfig()
        {
            return @"Server=(localdb)\mssqllocaldb;Database=ecommerce;Integrated Security=True";
        }
    }
}
