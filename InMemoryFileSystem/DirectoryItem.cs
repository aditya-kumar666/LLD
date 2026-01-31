using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryFileSystem
{
    internal class DirectoryItem : IFileSystemItem
    {
        public string Name { get; set; }
        public Dictionary<string, IFileSystemItem> Children { get; set; }
        public DirectoryItem(string name)
        {
            Name = name;
            Children = new();
        }
        public long GetSize()
        {
            return Children.Values.Sum(x => x.GetSize());
        }
    }
}
