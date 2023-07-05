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

        public OrderService()
        {
            this._employeeRepasitory = new EmployeeRepasitory();
            this._orderRepasitory = new OrderRepasitory();
            this._orderDetailRepasitory = new OrderDetailRepasitory();
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

        public Task<OrderViewModel> GetAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
