namespace Enterprise.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Employee> Employees { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];

        public Address Address { get; set; } = null!;

        public Description Description { get; set; } = null!;
    }
}