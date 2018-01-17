namespace Win32VersionHelpers
{
    public enum Conditions
    {
        /// <summary>
        /// The current value must be equal to the specified value.
        /// </summary>
        EqualTo = (int) Constants.VER_EQUAL,
        /// <summary>
        /// The current value must be greater than the specified value.
        /// </summary>
        GreaterThan = (int) Constants.VER_GREATER,
        /// <summary>
        /// The current value must be greater than or equal to the specified value.
        /// </summary>
        GreaterThanEqualTo = (int) Constants.VER_GREATER_EQUAL,
        /// <summary>
        /// The current value must be less than the specified value.
        /// </summary>
        LessThan = (int) Constants.VER_LESS,
        /// <summary>
        /// The current value must be less than or equal to the specified value.
        /// </summary>
        LessThanEqualTo = (int) Constants.VER_LESS_EQUAL,
        /// <summary>
        /// All product suites specified in the wSuiteMask member must be present in the current system.
        /// </summary>
        And = (int) Constants.VER_AND,
        /// <summary>
        /// At least one of the specified product suites must be present in the current system.
        /// </summary>
        Or = (int) Constants.VER_OR
    }
}