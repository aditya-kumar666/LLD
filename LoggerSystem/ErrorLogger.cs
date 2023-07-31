namespace LoggerSystem
{
    internal class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int levels)
        {
            this.levels = levels;
        }
        protected override void display(String msg, LoggerSubject loggerSubject)
        {
            loggerSubject.notifyAllObserver(2, "Error: " + msg);
        }
    }
}
