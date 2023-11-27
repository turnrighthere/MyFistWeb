using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Visual_learning_ytb.Models;

namespace Visual_learning_ytb.Data
{
    public class Visual_learning_ytbContext : DbContext
    {
        public Visual_learning_ytbContext (DbContextOptions<Visual_learning_ytbContext> options)
            : base(options)
        {
        }

        public DbSet<Visual_learning_ytb.Models.Category> Category { get; set; } = default!;

        public DbSet<Visual_learning_ytb.Models.Product>? Product { get; set; }

        public DbSet<Visual_learning_ytb.Models.User>? User { get; set; }
    }
}
