namespace VsSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageBuilder builder = new MessageBuilder();
            MessagePrinter printer = new MessagePrinter();
            MessageCounter counter = new MessageCounter();

            Console.WriteLine("Введите Ваше имя: ");

            string? name = Console.ReadLine();

            string message = builder.BuildMessage(name);

            counter.Increment();

            printer.Print(message);

            Console.WriteLine("Нажмите Enter для завершения");
            Console.WriteLine(counter.GetCounter());
            Console.ReadLine();
        }
    }
}
