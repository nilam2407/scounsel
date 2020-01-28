using System;
using Microsoft.EntityFrameworkCore;
using scounsel_api.Models;

namespace scounsel_api
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(string connectionString) : base(GetOptions(connectionString))
        //{
        //}

        //private static DbContextOptions GetOptions(string connectionString)
        //{
        //    return SqlServerDbContextOptionsExtensions.UseSq(new DbContextOptionsBuilder(), connectionString).Options;
        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Degree> Degrees { get; set; }

        public DbSet<Programs> Programs { get; set; }
    }
}
