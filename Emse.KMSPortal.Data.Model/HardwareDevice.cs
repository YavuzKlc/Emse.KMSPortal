using System;
using System.ComponentModel.DataAnnotations;
using Emse.Framework;
using Emse.KMSPortal.Data.Model.Enums;

namespace Emse.KMSPortal.Data.Model
{

    public class HardwareDevice : Entity<Guid>
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        public Availability Availability { get; set; }

        public Kiosk Kiosk { get; set; }

        public Guid KioskOId { get; set; }

        public HardwareDeviceType HardwareDeviceType { get; set; }

        public int HardwareDeviceTypeOId { get; set; }
    }
}
