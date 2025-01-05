namespace BookManager.API.Entities
{
    public class Loan
    {
        public Loan(int loanId, int userId, int bookId, DateTime loanDay, User user, Book book)
        {
            LoanId = loanId;
            UserId = userId;
            BookId = bookId;
            LoanDay = DateTime.Now;
            User = user;
            Book = book;
        }

        public int LoanId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime LoanDay { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
