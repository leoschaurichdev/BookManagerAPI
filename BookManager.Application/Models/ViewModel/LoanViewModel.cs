using BookManager.Core.Entities;

namespace BookManager.Application.Models.ViewModel
{
    public class LoanViewModel
    {
        public LoanViewModel(int userId, int bookId)
        {
            UserId = userId;
            BookId = BookId;
            LoanDate = DateTime.Now;

        }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime LoanDate { get; set; }

        public static LoanViewModel FromEntity(Loan entity)
            => new(entity.BookId, entity.UserId);
    }
}
