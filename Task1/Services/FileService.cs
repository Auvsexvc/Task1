using System.Collections.Generic;
using System.IO;
using Task1.Interfaces;

namespace Task1.Services
{
    public class FileService : IFileService
    {
        private readonly DirectoryInfo _directory;

        public FileService(DirectoryInfo directory)
        {
            _directory = directory;
        }

        public IEnumerable<FileInfo> GetFiles()
        {
            return _directory.EnumerateFiles("*.nupkg");
        }
    }
}