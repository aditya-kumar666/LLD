﻿namespace LoggerSystem
{
    internal class LogManager
    {
        internal static AbstractLogger doChaining()
        {
            AbstractLogger infoLogger = new InfoLogger(1);

            AbstractLogger errorLogger = new ErrorLogger(2);
            infoLogger.setNextLevelLogger(errorLogger);

            AbstractLogger debugLogger = new DebugLogger(3);
            errorLogger.setNextLevelLogger(debugLogger);

            return infoLogger;
        }

        public static LoggerSubject addObservers()
        {
            LoggerSubject loggerSubject = new LoggerSubject();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            loggerSubject.addObserver(1, consoleLogger);
            loggerSubject.addObserver(2, consoleLogger);
            loggerSubject.addObserver(3, consoleLogger);
            FileLogger fileLogger = new FileLogger();
            loggerSubject.addObserver(2, fileLogger);
            return loggerSubject;
        }
    }
}
