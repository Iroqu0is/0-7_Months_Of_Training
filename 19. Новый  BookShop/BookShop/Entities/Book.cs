namespace BookShop.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public Code Code { get; set; } = null!;

        public Price Price { get; set; } = null!;

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; } = null!;

        public Description Description { get; set; } = null!;

        public ICollection<Review> Reviews { get; set; } = [];

        public ICollection<BookAuthor> BookAuthor { get; set; } = [];
    }
}