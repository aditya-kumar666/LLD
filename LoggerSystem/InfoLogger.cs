namespace LoggerSystem
{
    internal class InfoLogger : AbstractLogger
    {
        public InfoLogger(int levels) {
            this.levels = levels;
        }

        protected override void display(string msg, LoggerSubject loggerSubject)
        {
            loggerSubject.notifyAllObserver(1, "Info: " + msg);
        }
    }
}
