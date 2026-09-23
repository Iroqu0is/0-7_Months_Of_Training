namespace ConsoleApp1
{
    public class Book : BaseEntity
    {
        public ICollection<Review>? Reviews { get; set; } = [];

        public ICollection<Author> Authors { get; set; } = [];

        public Price Price { get; set; } = null!;

        public ShortDescription? ShortDescription { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}