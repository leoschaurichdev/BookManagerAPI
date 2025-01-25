using BookManager.Core.Enums;

namespace BookManager.Application.Models.InputModel
{
    public class UpdateBookInputModel
    {
        public int Id { get; set; }
        public string Cover { get; set; }
        public string Localization { get; set; }

    }
}
