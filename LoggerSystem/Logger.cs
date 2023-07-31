namespace LoggerSystem
{
    internal class Logger
    {
        private static readonly object lockObj = new object ();
        private volatile static Logger logger;
        private volatile static AbstractLogger chainOfLogger;
        private volatile static LoggerSubject loggerSubject;

        private Logger()
        {
            if (logger != null)
                throw new Exception("Object already created");
        }

        public static Logger getLogger()
        {
            if (logger == null)
            {
                lock(lockObj) {
                    if (logger == null) {
                        logger = new Logger();
                        chainOfLogger = LogManager.doChaining();
                        loggerSubject = LogManager.addObservers();
                    }
                }
            }
            return logger;
        }

        public void info(String message)
        {
            createLog(1, message);
        }
        
        public void error(String message)
        {
            createLog(2, message);
        }
        
        public void debug(String message)
        {
            createLog(3, message);
        }

        private void createLog(int level, string message)
        {
            chainOfLogger.logMessage(level, message, loggerSubject);
        }
    }
}
