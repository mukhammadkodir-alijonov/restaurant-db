namespace restauran.console.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int TableName { get; set; }
        public double TotalSum { get; set; }
        public string OrderDate { get; set; } = string.Empty;
        public int MumberCount { get; set; }
        public int EmployeeId { get; set; }
        public bool isPaid { get; set; }
    }
}
