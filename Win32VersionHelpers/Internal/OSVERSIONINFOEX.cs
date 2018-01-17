using System.Runtime.InteropServices;

namespace Win32VersionHelpers
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct OSVERSIONINFOEX
    {
        internal static uint SizeOf => (uint) Marshal.SizeOf(typeof(OSVERSIONINFOEX));

        public uint dwOSVersionInfoSize;
        public uint dwMajorVersion;
        public uint dwMinorVersion;
        public uint dwBuildNumber;
        public uint dwPlatformId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] public string szCSDVersion;
        public ushort wServicePackMajor;
        public ushort wServicePackMinor;
        public ushort wSuiteMask;
        public byte wProductType;
        public byte wReserved;
    }
}