namespace Win32VersionHelpers
{
    public enum OsProductTypes
    {
        /// <summary>
        /// The system is a domain controller and the operating system is Windows Server 2012 , Windows Server 2008 R2, Windows Server 2008, Windows Server 2003, or Windows 2000 Server.
        /// </summary>
        DomainController = Constants.VER_NT_DOMAIN_CONTROLLER,
        /// <summary>
        /// The operating system is Windows Server 2012, Windows Server 2008 R2, Windows Server 2008, Windows Server 2003, or Windows 2000 Server.
        /// <para>
        /// Note that a server that is also a domain controller is reported as <see cref="DomainController"/>, not <see cref="Server"/>.
        /// </para>
        /// </summary>
        Server = Constants.VER_NT_SERVER,
        /// <summary>
        /// The operating system is Windows 8, Windows 7, Windows Vista, Windows XP Professional, Windows XP Home Edition, or Windows 2000 Professional.
        /// </summary>
        Worksation = Constants.VER_NT_WORKSTATION
    }
}