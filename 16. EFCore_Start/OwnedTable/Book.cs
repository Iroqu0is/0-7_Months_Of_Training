namespace OwnedTable
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public Description? Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}