using Microsoft.EntityFrameworkCore;
using TestCoreProject.Models;
using System;
using Microsoft.Extensions.Options;
using System.Configuration;

namespace TestCoreProject.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            //AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
        public DbSet<Student> Students { get; set; } = null!;

    }
}
