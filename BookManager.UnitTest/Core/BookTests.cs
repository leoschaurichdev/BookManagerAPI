using BookManager.Core.Entities;
using BookManager.UnitTests.Fakes;

namespace BookManager.UnitTests.Core
{
    public class BookTests
    {
        [Fact]
        public void BookIsCreated_Success()
        {
            // Arrange
            var book = FakeDataHelper.CreateFakeBook();

            // Act
            book.Update("Cover 1", "B88");

            // Assert
            Assert.Equal("Cover 1", book.Cover);
            Assert.Equal("B88", book.Localization);


        }
    }
}
