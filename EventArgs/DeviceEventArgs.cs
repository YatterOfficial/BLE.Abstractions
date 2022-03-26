using BLE.Abstractions.Contracts;

namespace BLE.Abstractions.EventArgs
{
    public class DeviceEventArgs : System.EventArgs
    {
        public IDevice Device;
    }
}