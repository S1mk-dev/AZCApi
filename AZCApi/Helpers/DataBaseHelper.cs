using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZCApi
{
    public class DataBaseHelper : DbContext
    {
        public DbSet<Station> Station { get; set; }
        public DbSet<Date> Date {get; set; }

        public DataBaseHelper(DbContextOptions<DataBaseHelper> options)
            : base(options)
        {

        }

        public DataBaseHelper()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP - 53P7MAE; Initial Catalog = CarFillingStation; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
    }
}
