using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OKBLOGAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace OKBLOGAPI.Domain
{
    public class OKBLOGContext : DbContext
    {
        public DbSet<Restaurant> Restaurant { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Table> Tables { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public OKBLOGContext()
        {
        }

        /// <summary>
        /// Constructor used for dependency injection.
        /// </summary>
        /// <param name="options"></param>
        public OKBLOGContext(DbContextOptions<OKBLOGContext> options) : base(options)
        {
        }

        /// <summary>
        /// Connection to azure database with connection string
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=tcp:okblog.database.windows.net,1433;" +
                    "Initial Catalog=OKBLOG;Persist Security Info=False;" +
                    "User ID=okblogsa;Password=;" +
                    "MultipleActiveResultSets=False; Encrypt=True;" +
                    "TrustServerCertificate=False;Connection Timeout=30;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
