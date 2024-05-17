using CompositeDesignPattern_FileSystem;
using Directory = CompositeDesignPattern_FileSystem.Directory;
using File = CompositeDesignPattern_FileSystem.File;

public class Program
{
    public static void Main(string[] args)
    {
        Directory movieDirectory = new Directory("Movie");

        FileSystem border = new File("Border");
        movieDirectory.Add(border);

        Directory comedyMovieDirectory = new Directory("ComedyMovie");
        File hulchul = new File("Hulchul");
        comedyMovieDirectory.Add(hulchul);

        movieDirectory.Add(comedyMovieDirectory);
        movieDirectory.ls();
    }
}