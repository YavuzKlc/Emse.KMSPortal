using System;
using System.ComponentModel.DataAnnotations;
using Emse.Framework;

namespace Emse.KMSPortal.Data.Model
{

    public class HardwareDeviceType : Entity<int>
    {
        [StringLength(50)]
        public string DeviceTypeName { get; set; }
    }
}
