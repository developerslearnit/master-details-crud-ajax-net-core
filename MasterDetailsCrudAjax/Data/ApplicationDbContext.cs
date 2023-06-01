using MasterDetailsCrudAjax.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MasterDetailsCrudAjax.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { }

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<AgentGuarantor> AgentGuarantors { get; set; }
        public virtual DbSet<Relationship> Relationships { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
