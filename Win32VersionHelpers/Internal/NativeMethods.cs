using System.Runtime.InteropServices;

namespace Win32VersionHelpers
{
    internal class NativeMethods
    {
        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern bool VerifyVersionInfo([In] OSVERSIONINFOEX lpVersionInfo, [In] uint dwTypeMask, [In] long dwConditionMask);

        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern long VerSetConditionMask([In] long dwlConditionMask, [In] uint dwTypeBitMask, [In] uint dwConditionMask);

        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern bool GetVersionEx([In, Out] ref OSVERSIONINFOEX lpVersionInfo);

        //[DllImport("User32.dll", SetLastError = true)]
        //public static extern int GetSystemMetrics([In] int nIndex);
    }
}