namespace BookManager.API.Entities
{
    public class Book
    {
        public Book(int bookId, string title, string author, string iSBN, int yearPublication)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string  Author { get; set; }
        public string  ISBN { get; set; }
        public int YearPublication { get; set; }

    }
}
