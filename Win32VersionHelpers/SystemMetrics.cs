using System;

namespace Win32VersionHelpers
{
    public class SystemMetrics
    {
        public static object GetMetric(SystemMetricTypes metricType, out Type valueType)
        {
            switch (metricType)
            {
                case SystemMetricTypes.StartupType:
                    valueType = typeof(WindowsStartupTypes);
                    break;
                case SystemMetricTypes.IsWindowsStarterEdition:
                case SystemMetricTypes.IsWindowsMediaCenterEdition:
                case SystemMetricTypes.IsSystemDocked:
                case SystemMetricTypes.IsTablePC:
                case SystemMetricTypes.IsRemoteSession:
                case SystemMetricTypes.IsShuttingDown:
                case SystemMetricTypes.IsSlowProcessor:
                    valueType = typeof(bool);
                    break;
                case SystemMetricTypes.Digitizers:
                    valueType = typeof(Digitizers);
                    break;
                case SystemMetricTypes.MonitorCount:
                    valueType = typeof(int);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(metricType), metricType, null);
            }

            var metric = NativeMethods.GetSystemMetrics((int) metricType);
            return valueType.IsEnum ? Enum.Parse(valueType, metric.ToString()) 
                : metric.GetType() != valueType ? Convert.ChangeType(metric, valueType) 
                : metric;
        }
    }

    public enum SystemMetricTypes
    {
        StartupType = Constants.SM_CLEANBOOT,
        IsWindowsStarterEdition = Constants.SM_STARTER,
        IsWindowsMediaCenterEdition = Constants.SM_MEDIACENTER,
        Digitizers = Constants.SM_DIGITIZER,
        MonitorCount = Constants.SM_CMONITORS,
        IsRemoteSession = Constants.SM_REMOTESESSION,
        IsShuttingDown = Constants.SM_SHUTTINGDOWN,
        IsSlowProcessor = Constants.SM_SLOWMACHINE,
        IsSystemDocked = Constants.SM_SYSTEMDOCKED,
        IsTablePC = Constants.SM_TABLETPC
    }

    public enum WindowsStartupTypes
    {
        NormalBoot = 0,
        SafeMode = 1,
        DafeModeWithNetworkBoot = 2
    }
    [Flags]
    public enum Digitizers
    {
        None = 0x00,
        IntegratedTouch = Constants.NID_INTEGRATED_TOUCH,
        ExternalTouch = Constants.NID_EXTERNAL_TOUCH,
        IntegratedPen = Constants.NID_INTEGRATED_PEN,
        ExternalPen = Constants.NID_EXTERNAL_PEN,
        MultiInput = Constants.NID_MULTI_INPUT,
        Ready = Constants.NID_READY
    }
}
