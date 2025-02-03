using BookManager.Application.Commands.DeleteBook;
using BookManager.Core.Entities;
using BookManager.Core.Repositories;
using FluentAssertions;
using Moq;
using NSubstitute;

namespace BookManager.UnitTests.Application
{
    public class DeleteBookHandlerTests
    {
        [Fact]
        public async Task BookExists_Delete_Success_NSubstitute()
        {
            // Arrange
            var book = new Book("Title", "Author", "ISBN", 2021, "Cover", "Localization");

            var repository = Substitute.For<IBookRepository>();
            repository.GetById(Arg.Any<int>()).Returns(Task.FromResult((Book?)book));
            repository.Update(Arg.Any<Book>()).Returns(Task.CompletedTask);

            var handler = new DeleteBookHandler(repository);
            var command = new DeleteBookCommand(1);

            // Act

            var result = await handler.Handle(command, new CancellationToken());

            // Assert

            Assert.True(result.IsSuccess);

            result.IsSuccess.Should().BeTrue();

            await repository.Received(1).GetById(1);
            await repository.Received(1).Update(Arg.Any<Book>());

        }

        [Fact]
        public async Task BookNotExists_Delete_Error_NSubstitute()
        {
            // Arrange
            var repository = Substitute.For<IBookRepository>();
            repository.GetById(Arg.Any<int>()).Returns(Task.FromResult((Book?)null));

            var handler = new DeleteBookHandler(repository);
            var command = new DeleteBookCommand(1);

            //Act

            var result = await handler.Handle(command, new CancellationToken());

            //Assert
            Assert.False(result.IsSuccess);


        }

        [Fact]
        public async Task BookExists_Delete_Success_Moq()
        {
            // Arrange
            var book = new Book("Title", "Author", "ISBN", 2021, "Cover", "Localization");

            var repository = Mock.Of<IBookRepository>(x =>
                x.GetById(It.IsAny<int>()) == Task.FromResult((Book?)book) &&
                x.Update(It.IsAny<Book>()) == Task.CompletedTask);


            var handler = new DeleteBookHandler(repository);
            var command = new DeleteBookCommand(1);

            // Act

            var result = await handler.Handle(command, new CancellationToken());

            // Assert

            Assert.True(result.IsSuccess);
            Mock.Get(repository).Verify(x => x.GetById(1), Times.Once);
            Mock.Get(repository).Verify(x => x.Update(It.IsAny<Book>()), Times.Once);

        }

        [Fact]
        public async Task BookNotExists_Delete_Error_Moq()
        {
            // Arrange
            var repository = Mock.Of<IBookRepository>(r => r.GetById(It.IsAny<int>()) == Task.FromResult((Book?)null));

            var handler = new DeleteBookHandler(repository);
            var command = new DeleteBookCommand(1);

            //Act

            var result = await handler.Handle(command, new CancellationToken());

            //Assert
            Assert.False(result.IsSuccess);
            Mock.Get(repository).Verify(x => x.GetById(1), Times.Once);
            Mock.Get(repository).Verify(x => x.Update(It.IsAny<Book>()), Times.Never);
        }
    }
}
