using BookManager.Core.Entities;
using BookManager.Core.Enums;

namespace BookManager.UnitTests.Core
{
    public class LoanTests
    {
        [Fact]
        public void LoanIsCreated_Success()
        {
            // Arrange
            var user = new User("John Doe", "john.doe@example.com", new DateTime(1990, 1, 1));
            var book = new Book("Sample Book", "Author Name", "1234567890", 2023, "cover.jpg", "A1");
            var loan = new Loan(user, book, DateTime.Now);

            // Act
            var userId = loan.UserId;
            var loanId = loan.LoanId;

            // Assert
            Assert.Equal(user.Id, userId);
            Assert.Equal(loan.Id, loanId);
            Assert.Equal(LoanStatus.Active, loan.LoanStatus);
            Assert.Equal(LoanSituation.Current, loan.LoanSituation);
        }
    }
}
