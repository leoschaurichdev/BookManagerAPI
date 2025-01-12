namespace BookManager.API.Entities
{
    public class Book
    {
        public Book(int bookId, string title, string author, string iSBN, int yearPublication, string cover, string localization)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
            Cover = null;
            Localization = null;
            Loans = [];

        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string  Author { get; set; }
        public string  ISBN { get; set; }
        public int YearPublication { get; set; }
        public string? Cover { get; set; }
        public string? Localization { get; set; }
        public List<Loan> Loans { get; set; }

    }
}
