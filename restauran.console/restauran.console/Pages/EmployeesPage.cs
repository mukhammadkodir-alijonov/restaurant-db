using restauran.console.Helpers;
using restauran.console.Pages.Employees;

namespace restauran.console.Pages
{
    public class EmployeesPage
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("1. Xodimlar ma'lumotlari");
            Console.WriteLine("2. Xodim ma'lumoti");
            Console.WriteLine("3. Xodim ma'lumotlarini qo'shish");
            Console.WriteLine("4. Xodim ma'lumotlarini yangilash");
            Console.WriteLine("5. Xodim ma'lumotlarini o'chirish");
            Console.WriteLine("0. Bosh menyu");
            var choose = Console.ReadLine();
            if (choose == "1") ReadAllPage.Run();
            else if (choose == "2") ReadPage.Run();
            else if (choose == "3") CreatePage.Run();
            else if (choose == "4") UpdatePage.Run();
            else if (choose == "5") DeletePage.Run();
            else if (choose == "6") MainPage.Run();
            else
            {
                MessageHelper.Error("Tanlov xato amalaga oshirildi");
                Thread.Sleep(2000);
                Run();
            }
        }
    }
}
