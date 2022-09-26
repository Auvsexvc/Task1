using System;
using System.IO;
using Task1.Services;

namespace Task1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Provide path.");
                Console.ReadLine();

                return;
            }

            var packagesDirectory = new DirectoryInfo(args[0]);

            if (!packagesDirectory.Exists)
            {
                Console.WriteLine("Provided path does not exist.");
                Console.ReadLine();

                return;
            }

            var packageService = new PackageService(packagesDirectory);
            var packages = packageService.GetPackagesFromDirectory();

            foreach (var nupkgFile in packages)
            {
                Console.WriteLine(nupkgFile.FullName);
            }

            Console.ReadLine();
        }
    }
}