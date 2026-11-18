namespace Enterprise.Entities
{
    public class EmployeeProfession
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public int ProfessionId { get; set; }
        public Profession Profession { get; set; } = null!;
    }
}