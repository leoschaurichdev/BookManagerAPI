using BookManager.Core.Enums;

namespace BookManager.Core.Entities
{
    public class Loan : BaseEntity
    {


    public Loan(User user, Book book, DateTime loanDate)
        {

            User = user;
            Book = book;
            LoanStatus = LoanStatus.Active;
            LoanSituation = LoanSituation.Current;
            LoanDate = DateTime.Today;

        }

        public Loan()
        {
            
        }

        public int LoanId { get; private set; }
        public int UserId { get; private set; }
        public int BookId { get; private set; }
        public DateTime LoanDate { get; private set; }
        public User User { get; private set; }
        public Book Book { get; private set; }
        public LoanStatus LoanStatus { get; private set; }
        public LoanSituation LoanSituation { get; private set; }
        public void StartLoan()
        {

            LoanDate = DateTime.Now;
            

        }

        public void FinishLoan()
        {
            LoanStatus = LoanStatus.Inactive;

            if(LoanDate.AddDays(7) < DateTime.Now)
            {
                LoanSituation = LoanSituation.Delayed;
            }
                       

            
        }
    }
}