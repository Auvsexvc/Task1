using System.Collections.Generic;
using System.IO;
using System.Linq;
using Task1.Data;
using Task1.Extensions;
using Task1.Interfaces;

namespace Task1.Services
{
    public class PackageService
    {
        private readonly IFileService _fileService;

        public PackageService(DirectoryInfo directory)
        {
            _fileService = new FileService(directory);
        }

        public IEnumerable<Package> GetPackagesFromDirectory()
        {
            var packages = _fileService.GetFiles().Select(x => x.ConvertToPackage());

            return packages.Sort();
        }
    }
}