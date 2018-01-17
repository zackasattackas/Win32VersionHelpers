using System.ComponentModel;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace Win32VersionHelpers
{
    /// <summary>
    /// This class contains functions that can be used to determine the current operating system version or identify whether it is a Windows or Windows Server release. These functions provide simple tests that use the <see cref="VerifyVersionInfo"/> function and the recommended greater than or equal to comparisons that are proven as a robust means to determine the operating system version.
    /// </summary>
    public sealed class VersionHelpers
    {
        /// <summary>
        /// Indicates if the current OS is a Windows Server release. Applications that need to distinguish between server and client versions of Windows should call this function.
        /// </summary>
        /// <returns>True if the current OS is a Windows Server version; otherwise, false.</returns>
        public static bool IsWindowsServer()
        {
            var osvi = new OsVersionInfo {ProductType = OsProductTypes.Server}.AddCondition(VersionInfoParts.ProductType, Conditions.EqualTo);

            return VerifyVersionInfo(osvi);
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows XP version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows XP version; otherwise, false.</returns>
        public static bool IsWindowsXPOrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 5,
                    MinorVersion = 1
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi);
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows XP with Service Pack 1 (SP1) version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows XP with SP1 version; otherwise, false.</returns>
        public static bool IsWindowsXPSP1OrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 5,
                    MinorVersion = 1,
                    ServicePackMajor = 1
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.ServicePackMajor, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi);
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows XP with Service Pack 2 (SP2) version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows XP with SP2 version number; otherwise, false.</returns>
        public static bool IsWindowsXPSP2OrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 5,
                    MinorVersion = 1,
                    ServicePackMajor = 2
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.ServicePackMajor, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi);
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows XP with Service Pack 3 (SP3) version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows XP with SP3 version; otherwise, false.</returns>
        public static bool IsWindowsXPSP3OrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 5,
                    MinorVersion = 1,
                    ServicePackMajor = 3
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.ServicePackMajor, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi);
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows Vista version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows Vista version; otherwise, false.</returns>
        public static bool IsWindowsVistaOrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 6,
                    MinorVersion = 0
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi); ;
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows Vista with Service Pack 1 (SP1) version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows Vista with SP1 version; otherwise, false.</returns>
        public static bool IsWindowsVistaSP1OrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 6,
                    MinorVersion = 0,
                    ServicePackMajor = 1
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.ServicePackMajor, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi); ;
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows Vista with Service Pack 2 (SP2) version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows Vista with SP2 version; otherwise, false.</returns>
        public static bool IsWindowsVistaSP2OrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 6,
                    MinorVersion = 0,
                    ServicePackMajor = 2
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.ServicePackMajor, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi); ;
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows 7 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows 7 version; otherwise, false.</returns>
        public static bool IsWindows7OrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 6,
                    MinorVersion = 1
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi); ;
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows 7 with Service Pack 1 (SP1) version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows 7 with SP1 version; otherwise, false.</returns>
        public static bool IsWindows7SP1OrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 6,
                    MinorVersion = 1,
                    ServicePackMajor = 1
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.ServicePackMajor, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi); ;
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows 8 version.
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows 8 version; otherwise, false.</returns>
        public static bool IsWindows8OrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 6,
                    MinorVersion = 2
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi);
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows 8.1 version.
        /// <para>
        /// For Windows 10, <see cref="IsWindows8Point1OrGreater"/> returns false unless the application contains a manifest that includes a compatibility section that contains the GUIDs that designate Windows 8.1 and/or Windows 10.
        /// </para>
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows 8.1 version; otherwise, false.</returns>
        public static bool IsWindows8Point1OrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 6,
                    MinorVersion = 3
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi);
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the Windows 10 version.
        /// <para>
        /// For Windows 10, <see cref="IsWindows10OrGreater"/> returns false unless the application contains a manifest that includes a compatibility section that contains the GUID that designates Windows 10.
        /// </para>
        /// </summary>
        /// <returns>True if the current OS version matches, or is greater than, the Windows 10 version; otherwise, false.</returns>
        public static bool IsWindows10OrGreater()
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = 10,
                    MinorVersion = 0
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi);
        }
        /// <summary>
        /// Indicates if the current OS version matches, or is greater than, the provided version information. This function is useful in confirming a version of Windows Server that doesn't share a version number with a client release.
        /// <para>
        /// Note: You should only use this function if the other provided version helper functions do not fit your scenario.
        /// </para>
        /// </summary>
        /// <param name="major">The major OS version number.</param>
        /// <param name="minor">The minor OS version number.</param>
        /// <param name="spMajor">The major Service Pack version number.</param>
        /// <returns>TRUE if the specified version matches, or is greater than, the version of the current Windows OS; otherwise, FALSE.</returns>
        public static bool IsWindowsVersionOrGreater(int major, int minor, int spMajor)
        {
            var osvi = new OsVersionInfo
                {
                    MajorVersion = major,
                    MinorVersion = minor,
                    ServicePackMajor = spMajor
                }
                .AddCondition(VersionInfoParts.MajorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.MinorVersion, Conditions.GreaterThanEqualTo)
                .AddCondition(VersionInfoParts.ServicePackMajor, Conditions.GreaterThanEqualTo);

            return VerifyVersionInfo(osvi);
        }
        /// <summary>
        /// Compares a set of operating system version requirements to the corresponding values for the currently running version of the system. This function is subject to manifest-based behavior.
        /// </summary>
        /// <param name="osvi">An <see cref="OsVersionInfo"/> object containing the operating system version requirements to compare.</param>
        /// <returns></returns>
        public static bool VerifyVersionInfo(OsVersionInfo osvi)
        {
            return NativeMethods.VerifyVersionInfo(osvi.ToNativeType(), osvi.GetTypeMask(), osvi.GetConditionsMask());
        }
        public static OsVersionInfo GetOsVersionInfo()
        {
            var osvi = new OSVERSIONINFOEX {dwOSVersionInfoSize = OSVERSIONINFOEX.SizeOf};
            if (!NativeMethods.GetVersionEx(ref osvi))
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
            return new OsVersionInfo(osvi);
        }
    }
}