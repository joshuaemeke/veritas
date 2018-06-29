using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Veritas.Models
{
 

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=Default")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}