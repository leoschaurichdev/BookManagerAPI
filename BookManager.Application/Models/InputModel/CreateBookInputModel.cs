using BookManager.Core.Entities;

namespace BookManager.Application.Models.InputModel
{
    public class CreateBookInputModel
    {
        public CreateBookInputModel(string title, string description, string author, string iSBN, int yearPublication, DateTime registrationDate, string cover, string localization)
        {
            Title = title;
            Description = description;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
            RegistrationDate = DateTime.Now;
            Cover = null;
            Localization = localization;

        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int YearPublication { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? Cover { get; set; }
        public string? Localization { get; set; }

        public Book ToEntity() => new(Title, Author, ISBN, YearPublication, Cover, Localization);

    }
}
