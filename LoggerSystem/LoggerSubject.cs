namespace LoggerSystem
{
    internal class LoggerSubject
    {
        Dictionary<int, List<ILogObserver>> logObservers = new();

        public void addObserver(int level, ILogObserver logObserver)
        {
            List<ILogObserver> currentLogger = logObservers.GetValueOrDefault(level, new List<ILogObserver>());
            currentLogger.Add(logObserver);
            logObservers[level] = currentLogger;
        }

        public void removeObserver(ILogObserver logObserver) {
            foreach(var item in logObservers)
            {
                item.Value.Remove(logObserver);
            }
        }

        public void notifyAllObserver(int level, string message) {
            foreach (var item in logObservers)
            {
                if(item.Key == level)
                {
                    item.Value.ForEach(observer => observer.log(message));
                }
            }
        }
    }
}
