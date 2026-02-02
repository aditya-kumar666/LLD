using InMemoryFileSystem;

public class FileSystemManager 
{
    readonly DirectoryItem _root;
    readonly long _totalCapacity;
    long _usedCapacity;

    public FileSystemManager(long capacity)
    {
        _totalCapacity = capacity;
        _usedCapacity = 0;
        _root = new DirectoryItem("root");
    }

    public long GetAvailableMemory() { 
        return _totalCapacity - _usedCapacity;
    }

    public void CreateFile(string path, string name, long size) { 
        if(_usedCapacity + size > _totalCapacity)
        {
            throw new InvalidOperationException("Not enough memory to create the file.");
        }

        var targetDir = NavigateToPath(path);
        if (targetDir.Children.ContainsKey(name))
        {
            throw new InvalidOperationException("File or directory with the same name already exists.");
        }

        var newFile = new FileItem(name, size);
        targetDir.Children[name] = newFile;

        _usedCapacity += size;
    }

    public void CreateDirectory(string path, string dirName)
    {
        var parent = NavigateToPath(path);

        if (parent.Children.ContainsKey(dirName))
            throw new ArgumentException("Directory already exists.");

        parent.Children[dirName] = new DirectoryItem(dirName);
    }


    public void DeleteFile(string path, string name)
    {
        var targetDir = NavigateToPath(path);
        if (!targetDir.Children.ContainsKey(name) || targetDir.Children[name] is not FileItem)
        {
            throw new InvalidOperationException("File does not exist.");
        }
        var fileToDelete = (FileItem)targetDir.Children[name];
        _usedCapacity -= fileToDelete.Size;
        targetDir.Children.Remove(name);
    }

    public List<string> ListFolder(string path) { 
        var targetDir = NavigateToPath(path);
        return targetDir.Children.Keys.ToList();
    }

    public List<string> Search(string name) { 
        List<string> results = new List<string>();
        SearchRecursive(_root, name, "", results);
        return results;
    }

    void SearchRecursive(DirectoryItem current, string name, string curPath, List<string> results)
    {
        foreach (var child in current.Children)
        {
            var childPath = string.IsNullOrEmpty(curPath) ? child.Key : $"{curPath}/{child.Key}";
            if (child.Key == name)
            {
                results.Add(childPath);
            }
            if (child.Value is DirectoryItem dir)
            {
                SearchRecursive(dir, name, childPath, results);
            }
        }
    }

    DirectoryItem NavigateToPath(string path)
    {
        var segments = path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
        DirectoryItem current = _root;
        foreach (var segment in segments)
        {
            if (!current.Children.ContainsKey(segment) || current.Children[segment] is not DirectoryItem)
            {
                throw new InvalidOperationException("Invalid path.");
            }
            current = (DirectoryItem)current.Children[segment];
        }
        return current;
    }
}       