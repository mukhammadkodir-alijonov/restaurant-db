using restauran.console.Helpers;

namespace restauran.console.Pages
{
    public class MainPage
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("1. Maxsulotlar");
            Console.WriteLine("2. Xodimlar");
            Console.WriteLine("3. Buyrutmalar");

            var choose = Console.ReadLine();
            if (choose == "1") ProductsPage.Run();
            else if (choose == "2") EmployeesPage.Run();
            else if (choose == "3") OrdersPage.Run();
            else
            {
                MessageHelper.Error("Tanlov xato amalaga oshirildi");
                Thread.Sleep(2000);
                MainPage.Run();
            }
        }
    }
}
