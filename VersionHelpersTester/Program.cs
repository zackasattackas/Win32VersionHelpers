using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Win32VersionHelpers;

namespace VersionHelpersTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Is Windows Server? {VersionHelpers.IsWindowsServer()}");

            Console.ReadKey();
        }
    }
}
