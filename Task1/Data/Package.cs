using System;

namespace Task1.Data
{
    public class Package
    {
        public string FullName { get; set; }
        public string Id { get; set; }
        public Version NumericVersion { get; set; }
        public string Suffix { get; set; }
    }
}