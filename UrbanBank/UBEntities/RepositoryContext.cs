using Microsoft.EntityFrameworkCore;
using System;
using UBEntities.Models;

namespace UBEntities
{
    public class RepositoryContext : DbContext
        {
          public RepositoryContext(DbContextOptions options)
              : base(options)
          {
          }
          public DbSet<Owner> Owners { get; set; }
          public DbSet<Account> Accounts { get; set; }
   }
}
