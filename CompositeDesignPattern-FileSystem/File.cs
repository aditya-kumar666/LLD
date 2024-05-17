namespace CompositeDesignPattern_FileSystem
{
    public class File : FileSystem
    {
        string fileName;

        public File(string name)
        {
            fileName = name;
        }

        public void ls()
        {
            Console.WriteLine("file name " + fileName);
        }
    }
}
