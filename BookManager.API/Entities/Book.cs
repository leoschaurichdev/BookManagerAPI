using System.Diagnostics.CodeAnalysis;

namespace BookManager.API.Entities
{
    public class Book
    {
        protected Book() { }
        public Book(int bookId, string title, string author, string iSBN, int yearPublication, string cover):base()
        {
            BookId = bookId;
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
            Cover = null;

        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string  Author { get; set; }
        public string  ISBN { get; set; }
        public int YearPublication { get; set; }
        public List<BookLoan> BookLoans { get; set; } = new List<BookLoan>();
        public string? Cover { get; set; }   

    }
}
