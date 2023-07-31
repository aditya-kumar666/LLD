namespace LoggerSystem
{
    internal class DebugLogger : AbstractLogger
    {
        public DebugLogger(int levels)
        {
            this.levels = levels;
        }

        protected override void display(string msg, LoggerSubject loggerSubject)
        {
            loggerSubject.notifyAllObserver(3, "Debug: "+msg);
        }
    }
}
