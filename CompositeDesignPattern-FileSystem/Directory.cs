namespace CompositeDesignPattern_FileSystem
{
    public class Directory : FileSystem
    {
        string directoryName;
        List<FileSystem> fileSystemList;

        public Directory(string name)
        {
            fileSystemList = new List<FileSystem>();
            directoryName = name;
        }

        public void Add(FileSystem fileSystem)
        {
            fileSystemList.Add(fileSystem);
        }

        public void ls()
        {
            Console.WriteLine("Directory name " + directoryName);

            foreach(FileSystem fileSystem in fileSystemList)
            {
                fileSystem.ls();
            }
        }
    }
}
