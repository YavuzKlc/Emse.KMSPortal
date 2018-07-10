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
    public class User : Entity<int>
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string SurName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(100)]
        public string DomainUserName { get; set; }

        public State State { get; set; }
        
        public int LanguageId { get; set; }

        //
        public List<Role> RoleList { get; set; }

        public Branch Branch { get; set; }

        public int BranchOId { get; set; }

        public List<HandheldDevice> HandheldDeviceList { get; set; }
    }
}
