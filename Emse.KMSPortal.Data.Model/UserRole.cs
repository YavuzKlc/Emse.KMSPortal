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
    public class UserRole : Entity<int>
    {
        public int RoleId { get; set; }
        
        public int UserId { get; set; }

        public List<User> UserList { get; set; }

        public List<Role> RoleList { get; set; }
    }
}
