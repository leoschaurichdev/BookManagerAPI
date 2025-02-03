using BookManager.Application.Commands.InsertBook;
using BookManager.Core.Entities;
using BookManager.Core.Repositories;
using FluentAssertions;
using Moq;
using NSubstitute;

namespace BookManager.UnitTests.Application
{
    public class InserBookHandlerTests
    {
        [Fact]
        public async Task InsertBookHandler_Success_NSubstitute()
        {
            // Arrange
            var repository = Substitute.For<IBookRepository>();
            repository.Add(Arg.Any<Book>()).Returns(Task.FromResult(1));

            var command = new InsertBookCommand(
                "Book eweewewew",
                "Description 1",
                "Author 1",
                "8182821828123",
                2021,
                DateTime.Now,
                "testetetetete",
                "B87"
            );

            var handler = new InsertBookHandler(repository);

            // Act
            var result = await handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.True(result.IsSuccess);
            await repository.Received(1).Add(Arg.Any<Book>());
        }

        [Fact]
        public async Task InsertBookHandler_Success_Moq()
        {
            // Arrange
            const int Id = 1;

            //var mock = new Mock<IBookRepository>();
            //mock.Setup(b => b.Add(It.IsAny<Book>())).ReturnsAsync(Id);

            var repository = Mock
                .Of<IBookRepository>(x => x.Add(It.IsAny<Book>()) == Task.FromResult(Id));

            var command = new InsertBookCommand(
                "Book eweewewew",
                "Description 1",
                "Author 1",
                "8182821828123",
                2021,
                DateTime.Now,
                "testetetetete",
                "B87"
            );

            var handler = new InsertBookHandler(repository);

            // Act
            var result = await handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.True(result.IsSuccess);

            result.IsSuccess.Should().BeTrue();

            Assert.Equal(Id, result.Data);

            result.Data.Should().Be(Id);

            Mock.Get(repository).Verify(r => r.Add(It.IsAny<Book>()), Times.Once);

        }
    }
}
