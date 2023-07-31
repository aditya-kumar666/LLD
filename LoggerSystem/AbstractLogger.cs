﻿namespace LoggerSystem
{
    internal abstract class AbstractLogger
    {
        public int levels;
        private AbstractLogger nextLevelLogger;

        public void setNextLevelLogger(AbstractLogger nextLevelLogger)
        {
            this.nextLevelLogger = nextLevelLogger;
        }

        public void logMessage(int levels, string msg, LoggerSubject loggerSubject)
        {
            if (this.levels == levels)
            {
                display(msg, loggerSubject);
            }

            if (nextLevelLogger != null)
            {
                nextLevelLogger.logMessage(levels, msg, loggerSubject);
            }
        }
        protected abstract void display(String msg, LoggerSubject loggerSubject);
    }
}
