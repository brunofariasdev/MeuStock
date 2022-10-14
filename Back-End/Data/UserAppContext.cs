using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stock.Models;

namespace UserApp.Data
{
    public class UserAppContext : DbContext
    {
        public UserAppContext(DbContextOptions<UserAppContext> options)
            : base(options)
        {
        }

        public DbSet<Stock.Models.User> User { get; set; } = default!;
        public DbSet<Stock.Models.Supplier> Suppliers { get; set; } = default!;
        public DbSet<Stock.Models.Product> Products { get; set; } = default!;
    }
}
