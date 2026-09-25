namespace OneToMany
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = [];

        public override string ToString()
        {
            return Name;
        }
    }
}