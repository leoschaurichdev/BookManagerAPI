using BookManager.Core.Entities;
using BookManager.Core.Enums;

namespace BookManager.Application.Models.ViewModel
{
    public class LoanViewModel
    {
        public LoanViewModel(int idUser, int idBook, DateTime loanDay, LoanSituation loanSituation, LoanStatus loanStatus)
        {
            IdUser = idUser;
            IdBook = idBook;
            LoanDay = loanDay;
            LoanSituation = loanSituation.ToDisplayString();
            LoanStatus = loanStatus.ToDisplayString();


        }
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public DateTime LoanDay { get; set; }
        public string LoanSituation { get; set; }
        public string LoanStatus { get; set; }

        public static LoanViewModel FromEntity(Loan entity)
            => new(entity.UserId, entity.BookId, entity.LoanDay, entity.LoanSituation, entity.LoanStatus);
    }
}
