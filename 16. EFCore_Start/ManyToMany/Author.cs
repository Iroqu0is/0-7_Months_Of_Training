namespace ManyToMany
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<BookAuthors> BookAuthors { get; set; } = [];

        public override string ToString()
        {
            return Name;
        }
    }
}