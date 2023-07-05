using ConsoleTables;
using restauran.console.Interfaces.Services;
using restauran.console.Services;

namespace restauran.console.Pages.Orders
{
    public class ReadAllPage
    {
        public static void Run()
        {
            var consoleTabale = new ConsoleTable("Id","Stol raqami","Summa","Holati","Misoz soni","Ma'sul ishchi", "Vaqt");
            IOrderService orderService = new OrderService();
            var orders = orderService.GetAllAsync().Result;
            foreach (var order in orders)
            {
                string status = order.isPaid ? "To'langan" : "To'lanmagan";
                consoleTabale.AddRow(order.Id,order.TableName,order.TotalSum,status,
                    order.MumberCount,order.EmployeeName,order.OrderDate);
            }
            consoleTabale.Write();
        }
    }
}
