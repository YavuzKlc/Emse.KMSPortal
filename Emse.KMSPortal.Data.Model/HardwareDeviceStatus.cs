using Emse.KMSPortal.Data.Model.Enums;
using System;

namespace Emse.KMSPortal.Data.Model
{
    public class HardwareDeviceStatus
    {
        public HardwareDevice HardwareDevice { get; set; }

        public Guid HardwareDeviceOId { get; set; }

        public HardwareDeviceState HardwareDeviceState { get; set; }
    }
}