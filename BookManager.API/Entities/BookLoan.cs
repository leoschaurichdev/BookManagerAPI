namespace BookManager.API.Entities
{
    public class BookLoan : BaseEntity
    {
        public BookLoan(int bookId, int loanId, DateTime loanDate, DateTime? returnDate):base()
        {
            BookId = bookId;
            LoanId = loanId;
            LoanDate = DateTime.Now;
            ReturnDate = null;
        }

        public int BookId { get; set; }
        public int LoanId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Book Book { get; set; }
        public Loan Loan { get; set; }
    }
}
