namespace restauran.console.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public double Salary { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
