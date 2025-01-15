using System.Buffers.Text;

namespace BookManager.API.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(int loanId, int userId, int bookId, DateTime loanDay, User user, Book book) : base()
        {
            LoanId = loanId;
            UserId = userId;
            BookId = bookId;
            LoanDay = DateTime.Now;
            User = user;
            Book = book;
        }

        public int LoanId { get; private set; }
        public int UserId { get; private set; }
        public int BookId { get; private set; }
        public DateTime LoanDay { get; private set; }
        public User User { get; private set; }
        public Book Book { get; private set; }
        public List<BookLoan> BookLoans { get; set; } = new List<BookLoan>();
    }
}