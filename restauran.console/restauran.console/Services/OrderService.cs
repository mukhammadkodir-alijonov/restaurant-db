using restauran.console.Interfaces.Repasitories;
using restauran.console.Interfaces.Services;
using restauran.console.Repasitories;
using restauran.console.ViewModels;

namespace restauran.console.Services
{
    public class OrderService : IOrderService
    {
        private readonly IEmployeeRepository _employeeRepasitory;
        private readonly IOrderRepository _orderRepasitory;
        private readonly IOrderDeatilRepository _orderDetailRepasitory;
        private readonly IProductRepasitory _productRepasitory;

        public OrderService()
        {
            this._employeeRepasitory = new EmployeeRepasitory();
            this._orderRepasitory = new OrderRepasitory();
            this._orderDetailRepasitory = new OrderDetailViewRepasitory();
            this._productRepasitory = new ProductRepository();
        }
        public async Task<IEnumerable<OrderViewModel>> GetAllAsync()
        {
            var orders = await _orderRepasitory.GetAllAsync();
            var orderViewModels = new List<OrderViewModel>();

            foreach (var order in orders)
            {
                var orderViewModel = (OrderViewModel)order;
                orderViewModel.EmployeeName = (await _employeeRepasitory.GetAsync(order.EmployeeId)).FullName;
                orderViewModels.Add(orderViewModel);
            }
            return orderViewModels;
        }

        public async Task<OrderViewModel> GetAsync(int id)
        {
            var order = await _orderRepasitory.GetAsync(id);
            var orderViewModel = (OrderViewModel)order;
            orderViewModel.EmployeeName = (await _employeeRepasitory.GetAsync(order.EmployeeId)).FullName;

            var orderDetails = (await _orderDetailRepasitory.GetAllAsync())
                .Where(x=>x.OrderId == order.Id)
                .ToList();

            foreach (var orderDetail in orderDetails)
            {
                var product = await _productRepasitory.GetAsync(orderDetail.ProductId);
                OrderDetailViewModel orderDetailViewModel = new OrderDetailViewModel()
                {
                    Id = orderDetail.Id,
                    Quantity = orderDetail.Quantity,    
                    Price = orderDetail.Quantity * product.Price,
                    ProductName = product.Name
                };
                orderViewModel.orderDetails.Add(orderDetailViewModel);
            }
            return orderViewModel;
        }
    }
}
