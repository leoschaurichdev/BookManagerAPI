using BookManager.Core.Enums;

namespace BookManager.Application.Models.InputModel
{
    public class UpdateLoanInputModel
    {
        public int LoanId { get; set; }
        public LoanStatus Status { get; set; }
        public LoanSituation Situation { get; set; }

    }
}
