using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Emse.Framework;
using Emse.KMSPortal.Data.Model.Enums;

namespace Emse.KMSPortal.Data.Model
{

    public class KioskStatus : Entity<Guid>
    {
        public Kiosk Kiosk { get; set; }

        public int KioskOId { get; set; }

        public OnOffState KioskState { get; set; }

        public bool RearDoorOpen { get; set; }

        public bool RightDoorOpen { get; set; }

        public bool LeftDoorOpen { get; set; }

        public bool LanConnection { get; set; }

        public bool DCSServiceConnection { get; set; }

        public bool CloudConnection { get; set; }

        public bool OverHeat { get; set; }

        public bool BeltWorking { get; set; }

        public List<HardwareDeviceStatus> HardwareDeviceStatusList { get; set; }
    }
}
