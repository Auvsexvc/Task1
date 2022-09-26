using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Task1.Data;

namespace Task1.Extensions
{
    public static class AppExtension
    {
        public static IEnumerable<Package> Sort(this IEnumerable<Package> packages)
        {
            return packages
                .GroupBy(x => x.Id)
                .Select(x => x.Any(p => string.IsNullOrEmpty(p.Suffix))
                    ? x.OrderByDescending(p => p.NumericVersion).ThenByDescending(p => p.Suffix).FirstOrDefault()
                    : x.OrderByDescending(p => p.NumericVersion).ThenBy(p => p.Suffix).FirstOrDefault());
        }

        public static Package ConvertToPackage(this FileInfo file)
        {
            var name = file.Name.Substring(0, file.Name.Length - file.Extension.Length);

            var fileParts = name.Split('.');
            var id = fileParts.FirstOrDefault();
            var ver = string.Join(".", fileParts.Skip(1).TakeWhile(x => !x.StartsWith("-")));
            var numericVer = string.IsNullOrEmpty(ver) ? new Version(ver) : new Version();
            var suffix = fileParts.SkipWhile(x => x.StartsWith("-"));

            return new Package()
            {
                FullName = name,
                Id = id,
                NumericVersion = numericVer,
                Suffix = suffix.Any() ? suffix.FirstOrDefault() : string.Empty,
            };
        }
    }
}