using BookManager.Core.Entities;

namespace BookManager.Application.Models.InputModel
{
    public class CreateBookInputModel
    {
        public CreateBookInputModel(string title, string description, string author, int iSBN, DateTime registrationDate, string cover, string localization)
        {
            Title = title;
            Description = description;
            Author = author;
            ISBN = iSBN;
            RegistrationDate = DateTime.Now;
            Cover = null;
            Localization = null;

        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? Cover { get; set; }
        public string? Localization { get; set; }

        public Book ToEntity() => new(Title, Description, Author, ISBN, RegistrationDate, Cover, Localization);

    }
}
