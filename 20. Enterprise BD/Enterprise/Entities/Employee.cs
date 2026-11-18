namespace Enterprise.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int? PositionId { get; set; }
        public PositionInCompany? Position { get; set; }

        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public Address Address { get; set; } = null!;
        public Description Description { get; set; } = null!;

        public ICollection<EmployeeProfession> EmployeeProfessions { get; set; } = [];
    }
}