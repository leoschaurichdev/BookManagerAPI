using BookManager.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Infrastructure.Persistence
{
    public class BookManagerDbContext : DbContext
    {
        public BookManagerDbContext (DbContextOptions<BookManagerDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Book> Books {  get; set; }    
        public DbSet<Loan> Loans { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>(x =>
                {
                    x.HasKey(x => x.Id);
                });
            builder
                .Entity<Book>(x =>
                {
                    x.HasKey(x => x.Id);
                });
            builder
                .Entity<Loan>(x =>
                {
                    x.HasKey(x => x.Id);

                    x.HasOne(x => x.User)
                        .WithMany(x => x.Loans)
                        .HasForeignKey(x => x.UserId)
                        .OnDelete(DeleteBehavior.Restrict);

                    x.HasOne(x => x.Book)
                        .WithMany(x => x.Loans)
                        .HasForeignKey(x => x.BookId)
                        .OnDelete(DeleteBehavior.Restrict);
                });

            base.OnModelCreating(builder);
        }
    }

}
