using System.Collections.Generic;
using System.IO;

namespace Task1.Interfaces
{
    public interface IFileService
    {
        IEnumerable<FileInfo> GetFiles();
    }
}