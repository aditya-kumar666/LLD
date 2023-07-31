namespace LoggerSystem
{
    internal class ConsoleLogger : ILogObserver
    {
        public void log(string message)
        {
            Console.WriteLine("Console msg: "+message);
        }
    }
}
