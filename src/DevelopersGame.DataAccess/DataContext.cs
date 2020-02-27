using System.Linq;
using System.Threading.Tasks;
using DevelopersGame.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevelopersGame.DataAccess
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
        
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        public DbSet<T> DbSet<T>() where T : class
        {
            return Set<T>();
        }

        public new IQueryable<T> Query<T>() where T : class
        {
            return Set<T>();
        }
    }
}