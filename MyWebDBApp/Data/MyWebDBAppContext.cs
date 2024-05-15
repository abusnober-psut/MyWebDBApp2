using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebDBApp.Models;

namespace MyWebDBApp.Data
{
    public class MyWebDBAppContext : DbContext
    {
        public MyWebDBAppContext (DbContextOptions<MyWebDBAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyWebDBApp.Models.Clients> Clients { get; set; } = default!;
    }
}
