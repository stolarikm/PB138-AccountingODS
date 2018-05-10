using System;
using System.IO;

namespace AccountingODS.Serialization
{
    public class Paths
    {
        public static string OutputFolderPath { get; } = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + Path.DirectorySeparatorChar + "Documents" + Path.DirectorySeparatorChar + "Output" + Path.DirectorySeparatorChar;
        public static string InputFolderPath { get; } = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + Path.DirectorySeparatorChar + "Documents" + Path.DirectorySeparatorChar + "Input" + Path.DirectorySeparatorChar;
    }
}
