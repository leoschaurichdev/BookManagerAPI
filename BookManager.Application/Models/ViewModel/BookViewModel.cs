
using BookManager.Core.Entities;

namespace BookManager.Application.Models.ViewModel
{
    public class BookViewModel
    {
        public BookViewModel(int id, string title, string author, string isbn, int yearOfPublication, bool isDeleted)
        {
            Id = id;
            Title = title;
            Author = author;
            Isbn = isbn;
            YearOfPublication = yearOfPublication;
            IsDeleted = isDeleted;

        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Isbn { get; private set; }
        public int YearOfPublication { get; private set; }
        public bool IsDeleted { get; private set; }

        public static BookViewModel FromEntity(Book entity)
            => new(entity.Id, entity.Title, entity.Author, entity.ISBN, entity.YearPublication, entity.IsDeleted);
    }
}
