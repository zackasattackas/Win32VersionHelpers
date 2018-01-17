using System;

namespace Win32VersionHelpers
{
    [Flags]
    public enum VersionInfoParts : uint
    {
        BuildNumber = Constants.VER_BUILDNUMBER,
        MajorVersion = Constants.VER_MAJORVERSION,
        MinorVersion = Constants.VER_MINORVERSION,
        PlatformId = Constants.VER_PLATFORMID,
        ProductType = Constants.VER_PRODUCT_TYPE,
        ServicePackMajor = Constants.VER_SERVICEPACKMAJOR,
        ServicePackMinor = Constants.VER_SERVICEPACKMINOR,
        SuiteName = Constants.VER_SUITENAME,
    }
}