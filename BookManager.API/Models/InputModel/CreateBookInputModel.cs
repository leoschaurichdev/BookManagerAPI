namespace BookManager.API.Models.InputModel
{
    public class CreateBookInputModel
    {
        public CreateBookInputModel(string title, string description, string author, string iSBN, DateTime registrationDate)
        {
            Title = title;
            Description = description;
            Author = author;
            ISBN = iSBN;
            RegistrationDate = DateTime.Now;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
