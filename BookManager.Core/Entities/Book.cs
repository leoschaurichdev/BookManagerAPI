namespace BookManager.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book(string title, string author, string iSBN, int yearPublication, string cover, string localization)
        {
        
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
            Cover = null;
            Localization = localization;
            Loans = [];

        }

        public string Title { get; set; }
        public string  Author { get; set; }
        public string  ISBN { get; set; }
        public int YearPublication { get; set; }
        public string? Cover { get; set; }
        public string Localization { get; set; }
        public List<Loan> Loans { get; set; }

        public void Update(string? cover, string? localization)
        {
            Cover = cover;
            Localization = localization;
        }

    }
}