using UBEntities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UBEntities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions db)
            : base(db)
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet <Account> Accounts { get; set; }
    }
}
