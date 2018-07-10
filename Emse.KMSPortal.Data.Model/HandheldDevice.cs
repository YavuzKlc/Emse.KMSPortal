using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Emse.Framework;
using Emse.KMSPortal.Data.Model.Enums;

namespace Emse.KMSPortal.Data.Model
{

    public class HandheldDevice : Entity<Guid>
    {
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// TODO: MacID ve Port bilgilerinden oluşturulan bir Id
        /// </summary>
        public int FingerPrintId { get; set; }
        
        /// <summary>
        /// İç Hat / Dış Hat Vb.
        /// </summary>
        public TerminalType TerminalType { get; set; }

        /// <summary>
        /// IST / ESB vb.
        /// </summary>
        [StringLength(50)]
        public string Staion { get; set; }

        [StringLength(255)]
        public string TestURL { get; set; }

        [StringLength(255)]
        public string ProductionURL { get; set; }

        public List<Kiosk> KioskList { get; set; }
        
        public List<User> UserList { get; set; }

    }
}
