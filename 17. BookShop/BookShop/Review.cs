namespace BookShop
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; } = null!;

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;

        public override string ToString()
        {
            return Comment;
        }
    }
}