using Emse.Framework;
using Emse.KMSPortal.Data.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emse.KMSPortal.Data.Model
{
    public class UserActivitiyLog : Entity<Guid>
    {
        public User User { get; set; }

        public int UserOId { get; set; }

        public UserActivitiyType UserActivitiyType { get; set; }

        public int UserActivitiyTypeOId { get; set; }

        public string ObjectName { get; set; }

        public string Comment { get; set; }
    }
}
