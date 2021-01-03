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
            var receiptModel = modelBuilder.Entity<Receipt>();

            receiptModel.ToTable("Receipts").HasKey(x => x.Id);
            receiptModel.OwnsMany(x => x.Ingredients, x => 
            {
                x.WithOwner().HasForeignKey(y => y.ReceiptId);
                x.HasKey(x => x.Id);
            });
            receiptModel.OwnsMany(x => x.Steps, x => 
            {
                x.WithOwner().HasForeignKey(x => x.ReceiptId);
                x.HasKey(x => x.Id);
            });
        }

        public void Save()
        {
            base.SaveChanges();
        }
    }
}