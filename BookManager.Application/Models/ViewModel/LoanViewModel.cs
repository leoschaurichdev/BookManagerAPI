using Azure.Identity;
using BookManager.Core.Entities;
using BookManager.Core.Enums;

namespace BookManager.Application.Models.ViewModel
{
    public class LoanViewModel
    {
        public LoanViewModel(int idUser,string userName, int idBook, string bookTitle, DateTime loanDay, LoanSituation loanSituation, LoanStatus loanStatus)
        {
            IdUser = idUser;
            UserName = userName;
            IdBook = idBook;
            BookTitle = bookTitle;
            LoanDay = DateTime.Today;
            LoanSituation = loanSituation.ToDisplayString();
            LoanStatus = loanStatus.ToDisplayString();
        }
        public int IdUser { get; set; }
        public string UserName { get; set; } 
        public int IdBook { get; set; }
        public string BookTitle { get; set; }
        public DateTime LoanDay { get; set; }
        public string LoanSituation { get; set; }
        public string LoanStatus { get; set; }

        public static LoanViewModel FromEntity(Loan entity)
            => new(entity.UserId,entity.User.Name, entity.BookId, entity.Book.Title, entity.LoanDay, entity.LoanSituation, entity.LoanStatus);
    }
}
