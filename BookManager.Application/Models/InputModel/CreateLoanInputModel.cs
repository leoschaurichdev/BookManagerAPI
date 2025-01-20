namespace BookManager.Application.Models.InputModel
{
    public class CreateLoanInputModel
    {
        public CreateLoanInputModel(int idBook, int idUser, DateTime loanDate)
        {
            IdBook = idBook;
            IdUser = idUser;
            LoanDate = DateTime.Today;
        }

        public int IdBook { get; set; }
        public int IdUser { get; set; }
        public DateTime LoanDate { get; set; }


    }
}
