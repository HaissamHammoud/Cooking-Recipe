using Microsoft.EntityFrameworkCore;
using Models;

namespace Receipts.Data.DataBase
{
    
    public class DataContext : DbContext, IUnitOfWork
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Receipt> Receipts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receipt>().ToTable("Receipts");
        }

        public void Save()
        {
            base.SaveChanges();
        }
    }
}