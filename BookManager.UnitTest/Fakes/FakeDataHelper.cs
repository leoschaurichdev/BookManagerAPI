using Bogus;
using BookManager.Core.Entities;

namespace BookManager.UnitTests.Fakes
{
    public class FakeDataHelper
    {
        private static readonly Faker _faker = new();

        public static Book CreateFakeBook()
        {
            return new Book(

                _faker.Commerce.ProductName(),
                _faker.Commerce.ProductDescription(),
                _faker.Random.Int(1000000, 999999999).ToString(),
                _faker.Random.Int(1000, 2025),
                _faker.Image.PicsumUrl(),
                _faker.Random.String(2)


            );
        }

            private static readonly Faker<Book> _bookFaker = new Faker<Book>();
    }
}

