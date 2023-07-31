namespace LoggerSystem
{
    internal class FileLogger : ILogObserver
    {
        public void log(string message)
        {
            Console.WriteLine("File msg: "+message);
        }
    }
}
