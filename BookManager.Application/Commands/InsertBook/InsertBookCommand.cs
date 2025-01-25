using BookManager.Application.Models.ViewModel;
using BookManager.Core.Entities;
using MediatR;

namespace BookManager.Application.Commands.InsertBook
{
    public class InsertBookCommand : IRequest<ResultViewModel<int>>
    {
        public InsertBookCommand(string title, string description, string author, string iSBN, int yearPublication, DateTime registrationDate, string? cover, string? localization)
        {
            Title = title;
            Description = description;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
            RegistrationDate = registrationDate;
            Cover = cover;
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

        public Book ToEntity() => new Book(Title, Author, ISBN, YearPublication, Cover, Localization);
    }
}
