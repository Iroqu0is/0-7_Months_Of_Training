namespace Enterprise.Entities
{
    public class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<EmployeeProfession> EmployeeProfessions { get; set; } = [];
    }
}