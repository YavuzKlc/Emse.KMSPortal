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
    public class UserActivitiyType : Entity<int>
    {
        public string Name { get; set; }
    }
}
