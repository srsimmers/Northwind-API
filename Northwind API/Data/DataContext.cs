using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Northwind_API.Models;

namespace Northwind_API.Data
{
    public class DataContext : DbContext
    { 
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductInfo> Info { get; set; }
    }
}
