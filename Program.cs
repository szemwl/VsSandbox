namespace VsSandbox
{
    internal class Program
    {
        private const string NameMessage = "Введите Ваше имя: ";
        private const string CountMessage = "Для выхода из программы напечатайте: \"no\"";
        private const string ExitMessage = "Нажмите Enter для завершения. С Вами поздаровались: ";

        private static void Main(string[] args)
        {
            MessageBuilder builder = new MessageBuilder();
            MessagePrinter printer = new MessagePrinter();
            MessageCounter counter = new MessageCounter();

            string? name = string.Empty;

            while (true)
            {
                Console.WriteLine(NameMessage);
                name = Console.ReadLine() ?? null;

                if (string.Equals(name, "no", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                string message = builder.BuildMessage(name);

                counter.Increment();

                printer.Print(message);
                Console.WriteLine(CountMessage);
            }

            Console.WriteLine(ExitMessage + counter.Count);
            Console.ReadLine();
        }
    }
}
