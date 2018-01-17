using System;

namespace Win32VersionHelpers
{
    public class OsVersionInfo
    {
        #region Fields

        private long _conditionMask = 0;
        private VersionInfoParts _partsToTest = 0;

        #endregion

        #region Properties

        /// <summary>
        /// The major version number of the operating system.
        /// </summary>
        public int MajorVersion { get; set; }
        /// <summary>
        /// The minor version number of the operating system.
        /// </summary>
        public int MinorVersion { get; set; }
        /// <summary>
        /// The build number of the operating system.
        /// </summary>
        public int BuildNumber { get; set; }
        /// <summary>
        /// The operating system platform. This member can be <see cref="OsPlatform.Win32NT"/>.
        /// </summary>
        public OsPlatform Platform { get; set; }
        /// <summary>
        /// Indicates the latest Service Pack installed on the system. If no Service Pack has been installed, the string is empty.
        /// </summary>
        public string CsdVersion { get; set; }
        /// <summary>
        /// The major version number of the latest Service Pack installed on the system. If no Service Pack has been installed, the value is zero.
        /// </summary>
        public int ServicePackMajor { get; set; }
        /// <summary>
        /// The minor version number of the latest Service Pack installed on the system.
        /// </summary>
        public int ServicePackMinor { get; set; }
        /// <summary>
        /// A flags value that identifies the product suites available on the system.
        /// </summary>
        public ProductSuites AvailableSuites { get; set; }
        /// <summary>
        /// Any additional information about the system.
        /// </summary>
        public OsProductTypes ProductType { get; set; }

        #endregion

        #region Ctors

        public OsVersionInfo()
        {            
        }

        public OsVersionInfo(int major, int minor, int spMajor)
        {
            this.MajorVersion = major;
            this.MinorVersion = minor;
            this.ServicePackMajor = spMajor;
        }

        internal OsVersionInfo(OSVERSIONINFOEX other)
        {
            this.MajorVersion = (int)other.dwMajorVersion;
            this.MinorVersion = (int)other.dwMinorVersion;
            this.BuildNumber = (int) other.dwBuildNumber;
            this.Platform = (OsPlatform) Enum.Parse(typeof(OsPlatform), other.dwPlatformId.ToString());
            this.CsdVersion = other.szCSDVersion;
            this.ServicePackMajor = other.wServicePackMajor;
            this.ServicePackMinor = other.wServicePackMinor;
            this.AvailableSuites = (ProductSuites) Enum.Parse(typeof(ProductSuites), other.wSuiteMask.ToString());
            this.ProductType = (OsProductTypes) Enum.Parse(typeof(OsProductTypes), other.wProductType.ToString());
        }

        #endregion

        #region Methods

        public OsVersionInfo AddCondition(VersionInfoParts part, Conditions condition)
        {
            this._conditionMask = NativeMethods.VerSetConditionMask(this._conditionMask, (uint) part, (uint) condition);
            this._partsToTest |= part;
            return this;
        }

        public long GetConditionsMask()
        {
            return this._conditionMask;
        }

        internal uint GetTypeMask()
        {
            return (uint) this._partsToTest;
        }

        internal OSVERSIONINFOEX ToNativeType()
        {
            return new OSVERSIONINFOEX
            {
                dwOSVersionInfoSize = OSVERSIONINFOEX.SizeOf,
                dwMajorVersion = (uint) this.MajorVersion,
                dwMinorVersion = (uint) this.MinorVersion,
                dwBuildNumber = (uint) this.BuildNumber,
                dwPlatformId = (uint) this.Platform,
                szCSDVersion = this.CsdVersion,
                wProductType = (byte) this.ProductType,
                wServicePackMajor = (ushort) this.ServicePackMajor,
                wServicePackMinor = (ushort) this.ServicePackMinor,
                wSuiteMask = (ushort) this.AvailableSuites
            };
        }

        #endregion

        #region Overrides of Object

        public override string ToString()
        {
            return new Version(this.MajorVersion, this.MinorVersion, this.BuildNumber).ToString();
        }

        #endregion
    }
}