using BookManager.Core.Enums;

namespace BookManager.Core.Entities
{
    public class Loan : BaseEntity
    {


    public Loan(User user, Book book, DateTime loanDay) : base()
        {

            User = user;
            Book = book;
            LoanStatus = LoanStatus.Active;
            LoanSituation = LoanSituation.Current;
            LoanDay = DateTime.Today;

        }

        public Loan()
        {
            
        }

        public int LoanId { get; private set; }
        public int UserId { get; private set; }
        public int BookId { get; private set; }
        public DateTime LoanDay { get; private set; }
        public User User { get; private set; }
        public Book Book { get; private set; }
        public List<BookLoan> BookLoans { get; set; } = new List<BookLoan>();
        public LoanStatus LoanStatus { get; private set; }
        public LoanSituation LoanSituation { get; private set; }
        public void StartLoan()
        {

            LoanDay = DateTime.Now;
            BookLoan bookLoan = new BookLoan(BookId, LoanId, LoanDay, null);
            BookLoans.Add(bookLoan);

        }

        public void FinishLoan()
        {
            LoanStatus = LoanStatus.Inactive;

            if(LoanDay.AddDays(7) < DateTime.Now)
            {
                LoanSituation = LoanSituation.Delayed;
            }

            BookLoan bookLoan = BookLoans.Find(x => x.BookId == BookId && x.LoanId == LoanId);
            bookLoan.ReturnDate = DateTime.Now;
        }
    }
}