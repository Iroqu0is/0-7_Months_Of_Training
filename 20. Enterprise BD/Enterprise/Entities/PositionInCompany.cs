namespace Enterprise.Entities
{
    public class PositionInCompany
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Employee> Employees { get; set; } = [];
    }
}