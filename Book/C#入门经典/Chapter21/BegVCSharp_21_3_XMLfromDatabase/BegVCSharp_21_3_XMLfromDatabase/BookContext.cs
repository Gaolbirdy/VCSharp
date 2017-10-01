namespace BegVCSharp_21_3_XMLfromDatabase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookContext : DbContext
    {
        public BookContext()
            : base("name=BookContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(e => e.Inventory)
                .WithOptional(e => e.Item)
                .HasForeignKey(e => e.Item_Code);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Inventory)
                .WithOptional(e => e.Store)
                .HasForeignKey(e => e.Store_StoreId);
        }
    }
}
