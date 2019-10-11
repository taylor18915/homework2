using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Candy_Stars.Data;

namespace Candy_Stars.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Candy_Stars.Data.Candy_Store> Candy_Store { get; set; }
        public DbSet<Candy_Stars.Data.Candy> Candy { get; set; }
        public DbSet<Candy_Stars.Data.Orders> Orders { get; set; }
    }
}
