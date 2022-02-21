using Microsoft.EntityFrameworkCore;
using TaskTracker.WebApi.Model;

namespace TaskTracker.WebApi.Context
{
    public class CRUDContext : DbContext
    {
        // PG SQL table Task 
        public DbSet<Task> Tasks { get; set; }

        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {
        }
    }
}