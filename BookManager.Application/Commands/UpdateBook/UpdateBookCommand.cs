using BookManager.Application.Models.ViewModel;
using MediatR;

namespace BookManager.Application.Commands.UpdateBook
{
    public class UpdateBookCommand : IRequest<ResultViewModel>
    {
        public UpdateBookCommand(int id, string cover, string localization)
        {
            Id = id;
            Cover = cover;
            Localization = localization;
        }

        public int Id { get; set; }
        public string Cover { get; set; }
        public string Localization { get; set; }
    }
}
