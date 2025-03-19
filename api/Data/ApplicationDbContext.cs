using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }

        public DbSet<Stock> Stock {get; set;}
        public DbSet<Comment> Comments {get; set;}
    }
}