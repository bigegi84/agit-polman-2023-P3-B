using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agit_polman_2023_P3_B.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["AppDb"].ConnectionString);
            //optionsBuilder.UseSqlServer("Server= localhost\\sqlexpress; Initial Catalog= agit-polman-2023-B; Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
