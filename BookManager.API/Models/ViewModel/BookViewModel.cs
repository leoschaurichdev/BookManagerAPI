using BookManager.API.Entities;

namespace BookManager.API.Models.ViewModel
{
    public class BookViewModel
    {

        public BookViewModel(string title, string author, string iSBN, int yearPublication)
        {

            Title = title;
            Author = author;
            ISBN = iSBN;
            this.YearPublication = yearPublication;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int YearPublication { get; set; }
        public string Cover { get; set; }
        public string Localization { get; set; }
        public List<string> BookLoans { get; set; }
        public static BookViewModel FromEntity(Book entity)
    => new(entity.Title, entity.Author, entity.ISBN, entity.YearPublication);
    }
}
