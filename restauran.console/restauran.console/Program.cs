using restauran.console.Interfaces.Repasitories;
using restauran.console.Models;
using restauran.console.Pages;
using restauran.console.Repasitories;

namespace restauran.console
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            MainPage.Run();

            /*Product product = new Product()
            {
                Id = 3,
                Name = "Sho'rva 1pr",
                Description = "Tovuq goshtli",
                Price = 18000
            };
            IProductRepasitory productRepasitory = new ProductRepository();
            await productRepasitory.CreateAsync(product);*/

            /*Employee employee = new Employee()
            {
                Id = 2,
                FullName = "Muhammad",
                Description = "TezMan",
                PhoneNumber = "+998936661232",
                Position = "Ofitsant",
                Salary = 3500000
            };
            IEmployeeRepository employeeRepository = new EmployeeRepasitory();
            await employeeRepository.CreateAsync(employee);*/

            /*Order order = new Order()
            {
                Id = 4,
                EmployeeId = 2,
                TableName = 10,
                OrderDate = DateTime.Now.ToString(),
                MumberCount = 5,
                TotalSum = 0,
                isPaid = false
            };
            IOrderRepository orderRepository = new OrderRepasitory();
            await orderRepository.CreateAsync(order);*/

            /*OrderDetail orderDetail = new OrderDetail()
            {
                Id = 4,
                OrderId = 1,
                ProductId = 3,
                Quantity = 2
            };
            IOrderDeatilRepository orderDeatilRepository = new OrderDetailRepasitory();
            await orderDeatilRepository.CreateAsync(orderDetail);*/
        }
    }
}