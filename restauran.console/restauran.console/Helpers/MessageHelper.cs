namespace restauran.console.Helpers
{
    public class MessageHelper
    {
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Xatoli bo'ldi!");
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Information(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Successful(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Muvaffaqqiyatli");
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
