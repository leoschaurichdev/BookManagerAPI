using BookManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookManager.API.Persistence
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
                .Entity<User>(u =>
                {
                    u.HasKey(u=>u.Id);
                    u.Property(u => u.Name).IsRequired();
                });

            builder
                .Entity<Book>(b =>
                {
                    b.HasKey(b => b.Id);
                });

            builder
                .Entity<Loan>(l =>
                {
                    l.HasKey(l => l.LoanId);

                    l.HasOne(l=>l.User)
                    .WithMany(l=>l.Loans)
                    .HasForeignKey(l=>l.UserId)
                    .OnDelete(DeleteBehavior.Restrict);

                    l.HasOne(l =>l.Book)
                        .WithMany(l=>l.Loans)
                        .HasForeignKey(l=>l.BookId)
                        .OnDelete(DeleteBehavior.Restrict);

                });

            base.OnModelCreating(builder);
        }
    }

}
