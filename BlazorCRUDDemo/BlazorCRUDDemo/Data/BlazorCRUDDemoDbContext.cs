using System.Diagnostics.Contracts;
using BlazorCRUDDemo.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDDemo.Data
{
    public class BlazorCRUDDemoDbContext: DbContext
    {

      public BlazorCRUDDemoDbContext(DbContextOptions<BlazorCRUDDemoDbContext> options): base(options)
      { 
       

      }

      public DbSet<Product> Products=>Set<Product>();

    }
}
