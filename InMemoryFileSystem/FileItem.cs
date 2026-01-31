using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryFileSystem
{
    internal class FileItem : IFileSystemItem
    {
        public string Name { get ; set; }
        public long Size { get; set; }  
        public byte[] Content { get; set; }

        public FileItem(string name, long size)
        {
            Name = name;
            Size = size;
            Content = new byte[Size];
        }
        public long GetSize()
        {
            return Size;
        }
    }
}
