using FlyweightDesignPattern;

public class Program
{
    public static void Main(string[] args)
    {
        /*
            this is the data we want to write into the word processor.
        
            Total = 58 characters
            t = 7 times
            h = 3 times
            a = 3 times and so on...
        
         */

        ILetter obj1 = LetterFactory.createLetter('t');
        obj1.display(0, 0);

        ILetter obj2 = LetterFactory.createLetter('t');
        obj1.display(0, 6);
    }
}