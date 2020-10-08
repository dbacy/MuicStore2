using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MuicStore2.Models;

namespace MuicStore2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MuicStore2.Models.Song> Songs { get; set; }
        public DbSet<MuicStore2.Models.Customer> Customers { get; set; }
    }
}
