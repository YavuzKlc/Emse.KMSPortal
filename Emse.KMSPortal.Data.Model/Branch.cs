using Emse.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emse.KMSPortal.Data.Model
{
    public class Branch : Entity<int>
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ChiefEmail { get; set; }

        public List<User> UserList { get; set; }

        public List<Kiosk> KioskList { get; set; }
    }
}
