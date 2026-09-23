namespace ConsoleApp1
{
    public class Review
    {
        public int Id { get; set; }
        public string? Text { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}