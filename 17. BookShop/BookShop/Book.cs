namespace BookShop
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public Exposition? Exposition { get; set; }

        public ICollection<BookAuthors> BookAuthors { get; set; } = [];

        public ICollection<Review> Reviews { get; set; } = [];

        public Price Price { get; set; } = null!;

        public override string ToString()
        {
            return Title;
        }
    }
}