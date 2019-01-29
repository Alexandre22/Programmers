using ProgrammersCRUD.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProgrammersCRUD.DAL
{
    public class ProgramaDBContext : DbContext
    {
        public ProgramaDBContext() : base("ProgramaDBContext")
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}