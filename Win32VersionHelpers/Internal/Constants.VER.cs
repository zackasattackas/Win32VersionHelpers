namespace Win32VersionHelpers
{
    internal partial class Constants
    {
        public const uint VER_BUILDNUMBER = 0x0000004;
        public const uint VER_MAJORVERSION = 0x0000002;
        public const uint VER_MINORVERSION = 0x0000001;
        public const uint VER_PLATFORMID = 0x0000008;
        public const uint VER_SERVICEPACKMAJOR = 0x0000020;
        public const uint VER_SERVICEPACKMINOR = 0x0000010;
        public const uint VER_SUITENAME = 0x0000040;
        public const uint VER_PRODUCT_TYPE = 0x0000080;
       
        public const uint VER_EQUAL = 1;
        public const uint VER_GREATER = 2;
        public const uint VER_GREATER_EQUAL = 3;
        public const uint VER_LESS = 4;
        public const uint VER_LESS_EQUAL = 5;
        public const uint VER_AND = 6;
        public const uint VER_OR = 7;

        public const uint VER_PLATFORM_WIN32_NT = 2;

        public const uint VER_SUITE_BACKOFFICE = 0x00000004;
        public const uint VER_SUITE_BLADE = 0x00000400;
        public const uint VER_SUITE_COMPUTE_SERVER = 0x00004000;
        public const uint VER_SUITE_DATACENTER = 0x00000080;
        public const uint VER_SUITE_ENTERPRISE = 0x00000002;
        public const uint VER_SUITE_EMBEDDEDNT = 0x00000040;
        public const uint VER_SUITE_PERSONAL = 0x00000200;
        public const uint VER_SUITE_SINGLEUSERTS = 0x00000100;
        public const uint VER_SUITE_SMALLBUSINESS = 0x00000001;
        public const uint VER_SUITE_SMALLBUSINESS_RESTRICTED = 0x00000020;
        public const uint VER_SUITE_STORAGE_SERVER = 0x00002000;
        public const uint VER_SUITE_TERMINAL = 0x00000010;
        public const uint VER_SUITE_WH_SERVER = 0x00008000;

        public const byte VER_NT_DOMAIN_CONTROLLER = 0x0000002;
        public const byte VER_NT_SERVER = 0x0000003;
        public const byte VER_NT_WORKSTATION = 0x0000001;
    }
}