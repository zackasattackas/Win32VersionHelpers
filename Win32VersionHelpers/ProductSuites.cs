using System;

namespace Win32VersionHelpers
{
    [Flags]
    public enum ProductSuites : uint
    {
        /// <summary>
        /// Microsoft BackOffice components are installed.
        /// </summary>
        BackOffice = Constants.VER_SUITE_BACKOFFICE,
        /// <summary>
        /// Windows Server 2003, Web Edition is installed.
        /// </summary>
        Blade = Constants.VER_SUITE_BLADE,
        /// <summary>
        /// Windows Server 2003, Compute Cluster Edition is installed.
        /// </summary>
        ComputeServer = Constants.VER_SUITE_COMPUTE_SERVER,
        /// <summary>
        /// Windows Server 2008 Datacenter, Windows Server 2003, Datacenter Edition, or Windows 2000 Datacenter Server is installed.
        /// </summary>
        Datacenter = Constants.VER_SUITE_DATACENTER,
        /// <summary>
        /// Windows Server 2008 Enterprise, Windows Server 2003, Enterprise Edition, or Windows 2000 Advanced Server is installed.
        /// </summary>
        Enterprise = Constants.VER_SUITE_ENTERPRISE,
        /// <summary>
        /// Windows XP Embedded is installed.
        /// </summary>
        EmbeddedNT = Constants.VER_SUITE_EMBEDDEDNT,
        /// <summary>
        /// Windows Vista Home Premium, Windows Vista Home Basic, or Windows XP Home Edition is installed.
        /// </summary>
        Personal = Constants.VER_SUITE_PERSONAL,
        /// <summary>
        /// Remote Desktop is supported, but only one interactive session is supported. This value is set unless the system is running in application server mode.
        /// </summary>
        SingleUserTS = Constants.VER_SUITE_SINGLEUSERTS,
        /// <summary>
        /// Microsoft Small Business Server was once installed on the system, but may have been upgraded to another version of Windows.
        /// </summary>
        SmallBusiness = Constants.VER_SUITE_SMALLBUSINESS,
        /// <summary>
        /// Microsoft Small Business Server is installed with the restrictive client license in force.
        /// </summary>
        SmallBusinessRestricted = Constants.VER_SUITE_SMALLBUSINESS_RESTRICTED,
        /// <summary>
        /// Windows Storage Server 2003 R2 or Windows Storage Server 2003is installed.
        /// </summary>
        StorageServer = Constants.VER_SUITE_STORAGE_SERVER,
        /// <summary>
        /// Terminal Services is installed. This value is always set.
        /// <para>
        /// If <see cref="TerminalServer"/> is set but <see cref="SingleUserTS"/> is not set, the system is running in application server mode.
        /// </para>
        /// </summary>
        TerminalServer = Constants.VER_SUITE_BLADE,
        /// <summary>
        /// Windows Home Server is installed.
        /// </summary>
        HomeServer = Constants.VER_SUITE_WH_SERVER
    }
}