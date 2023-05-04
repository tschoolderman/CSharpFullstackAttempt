using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DatabaseContext : DbContext  // om de options door te geven aan de back-end
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        public DbSet<Train> trains { get; set; }
    }
}
