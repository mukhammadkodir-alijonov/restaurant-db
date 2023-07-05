using ConsoleTables;
using restauran.console.Helpers;
using restauran.console.Interfaces.Repasitories;
using restauran.console.Interfaces.Services;
using restauran.console.Repasitories;
using restauran.console.Services;

namespace restauran.console.Pages.Orders
{
    public class ReadPage
    {
        public static void Run()
        {
            Console.WriteLine("Buyrutma id sini kiriting: ");
            long id  = long.Parse(Console.ReadLine());
            var consoleTabale = new ConsoleTable("Id", "Stol raqami", "Summa", "Holati", "Misoz soni", "Ma'sul ishchi", "Vaqt");
            IOrderService orderService = new OrderService();
            var order = orderService.GetAsync(id).Result;
                string status = order.isPaid ? "To'langan" : "To'lanmagan";
                consoleTabale.AddRow(order.Id, order.TableName, order.TotalSum, status,
                order.MumberCount, order.EmployeeName, order.OrderDate);
            consoleTabale.Write();
            MessageHelper.Information("BUyrutma maxsulotlari");
            consoleTabale = new ConsoleTable("BuyrutmaRaqami","maxsulot nomi","");

        }
    }
}
