using System.Diagnostics.Contracts;
using BlazorCRUDDemoShared.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDDemoShared.Data
{
    public class BlazorCRUDDemoDbContext: DbContext
    {

      public BlazorCRUDDemoDbContext(DbContextOptions<BlazorCRUDDemoDbContext> options): base(options)
      { 
       

      }

      public DbSet<Product> Products=>Set<Product>();

    }
}
