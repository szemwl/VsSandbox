namespace VsSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageBuilder builder = new MessageBuilder();
            MessagePrinter printer = new MessagePrinter();

            Console.WriteLine("Введите имя: ");

            string? name = Console.ReadLine();

            string message = builder.BuildMessage(name);

            printer.Print(message);

            Console.WriteLine("Нажмите Enter для завершения");
            Console.ReadLine();
        }
    }
}
