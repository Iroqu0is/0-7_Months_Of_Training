namespace ConsoleApp1
{
    public class Author : BaseEntity
    {
        public ICollection<Book> Books { get; set; } = [];

        public override string ToString()
        {
            return base.ToString();
        }
    }
}