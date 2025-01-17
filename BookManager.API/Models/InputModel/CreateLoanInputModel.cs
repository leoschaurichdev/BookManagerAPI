using BookManager.API.Entities;

namespace BookManager.API.Models.InputModel
{
    public class CreateLoanInputModel
    {
        public CreateLoanInputModel(int idBook, int idUser, DateTime loanDate)
        {
            IdBook = idBook;
            IdUser = idUser;
            LoanDate = loanDate;
        }

        public int IdBook { get; set; }
        public int IdUser { get; set; }
        public DateTime LoanDate { get; set; }


    }
}
