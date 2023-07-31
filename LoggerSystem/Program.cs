using LoggerSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = Logger.getLogger();
        //logger.info("this is an info");
        //logger.debug("this is a debug");
        logger.error("this is an error");
    }
}