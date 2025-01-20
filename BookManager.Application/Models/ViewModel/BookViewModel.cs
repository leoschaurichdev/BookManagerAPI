using BookManager.Core.Entities;

namespace BookManager.Application.Models.ViewModel
{
    public class BookViewModel
    {

        public BookViewModel(int id, string title, string author, string iSBN, int yearPublication, string localization)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
            Localization = localization;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int YearPublication { get; set; }
        public string Cover { get; set; }
        public string Localization { get; set; }
        public List<string> BookLoans { get; set; }
        public static BookViewModel FromEntity(Book entity)
    => new(entity.Id, entity.Title, entity.Author, entity.ISBN, entity.YearPublication, entity.Localization);
    }
}
