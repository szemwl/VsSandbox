namespace VsSandbox
{
    internal class MessageCounter
    {
        private int _counter;

        public void Increment() => _counter++;

        public int Count => _counter;
    }
}
