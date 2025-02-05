using BookManager.Core.Enums;
using System.Security.Cryptography.X509Certificates;

namespace BookManager.Core.Entities
{
    public class Loan : BaseEntity
    {
        
        public Loan(User user, Book book, DateTime loanDay)
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
        public int UserId { get; private set; }
        public int BookId { get; private set; }
        public User User { get; private set; }
        public Book Book { get; private set; }
        public DateTime LoanDay { get; private set; }
        public LoanStatus LoanStatus { get; private set; }
        public LoanSituation LoanSituation { get; private set; }
        public void FinishLoan()
        {
            LoanStatus = LoanStatus.Inactive;
            UpdateAt = DateTime.Now;
        }

        public void LateLoan()
        {
            LoanSituation = LoanSituation.Delayed;
        }
       
    }
}