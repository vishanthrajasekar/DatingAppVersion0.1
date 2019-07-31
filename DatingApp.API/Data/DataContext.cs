using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext 
    {
       public DataContext(DbContextOptions<DataContext> options) : base (options) {}

       //In our data context class in order to tell entity framework about our entities we need to give it
       //some properties and these properties are type db set 
       //Here the <Value> is the enity
        public DbSet<Value> Values { get; set; }

    }
}