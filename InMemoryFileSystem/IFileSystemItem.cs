using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryFileSystem
{
    internal interface IFileSystemItem
    {
        string Name { get; set; }
        long GetSize();
    }
}
