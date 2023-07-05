using restauran.console.Models;

namespace restauran.console.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int TableName { get; set; }
        public double TotalSum { get; set; }
        public string OrderDate { get; set; } = string.Empty;
        public int MumberCount { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public bool isPaid { get; set; }
        public IList<OrderDetailViewModel> orderDetails{ get; set; }
        public OrderViewModel()
        {
            orderDetails  = new List<OrderDetailViewModel>();
        }
        public static implicit operator OrderViewModel(Order order)
        {
            return new OrderViewModel()
            {
                Id = order.Id,
                MumberCount = order.MumberCount,
                TableName = order.TableName,
                isPaid = order.isPaid,
                TotalSum = order.TotalSum,
                OrderDate = order.OrderDate
            };
        }
    }
}
